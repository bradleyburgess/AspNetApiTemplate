using System.Net;
using AspNetApiTemplate.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetApiTemplate.Tests.Controllers;

public class HealthcheckControllerTests
{
    [Fact]
    public void Returns_ActionResult()
    {
        var controller = new HealthcheckController();
        var result = controller.Healthcheck()!;
        var okResult = Assert.IsType<OkObjectResult>(result);
        var value = Assert.IsType<string>(okResult.Value);
        Assert.Equal("OK", value);
        Assert.Equal(StatusCodes.Status200OK, okResult.StatusCode);
    }
}
