using EgitimPortal.Application.Bases;
using EgitimPortal.Application.Features.Auth.UpdateUser;
using EgitimPortal.Application.Interfaces.AutoMapper;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EgitimPortal.Application.Features.Auth.Command.UpdateUser
{
    public class UpdateUserCommandHandler : BaseHandler, IRequestHandler<UpdateUserCommandRequest, Unit>
    {
        private readonly UserManager<User> userManager;

        public UpdateUserCommandHandler(UserManager<User> userManager, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
            : base(mapper, unitOfWork, httpContextAccessor)
        {
            this.userManager = userManager;
        }

        public async Task<Unit> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            // Kullanıcıyı bul
            var user = await userManager.FindByIdAsync(request.UserId.ToString());
            if (user == null)
            {
                throw new Exception("Kullanıcı bulunamadı.");
            }

            // Kullanıcı bilgilerini güncelle
            user.FullName = request.FullName;
            user.Email = request.Email;
            user.UserName = request.Email; // E-posta adresini kullanıcı adı olarak ayarlayın

            // Şifre güncelleme isteği varsa
            if (!string.IsNullOrEmpty(request.Password))
            {
                var passwordChangeResult = await userManager.ChangePasswordAsync(user, request.Password, request.ConfirmPassword);
                if (!passwordChangeResult.Succeeded)
                {
                    throw new Exception("Şifre güncellenirken hata oluştu.");
                }
            }

            // Kullanıcı bilgilerini güncelle
            var updateResult = await userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                throw new Exception("Kullanıcı bilgileri güncellenirken hata oluştu.");
            }

            return Unit.Value;
        }
    }
}