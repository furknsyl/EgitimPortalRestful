using EgitimPortal.Application.Features.Auth.Command.Register;
using EgitimPortal.Application.Features.Auth.Rules;
using EgitimPortal.Application.Interfaces.AutoMapper;
using EgitimPortal.Application.Interfaces.UnitOfWorks;
using EgitimPortal.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

public class RegisterCommandHandlerTests
{
   

    public RegisterCommandHandlerTests()
    {
        
    }

    [Fact]
    public async Task Handle_ShouldCreateUser_WhenUserDoesNotExist()
    {
        
    }
}