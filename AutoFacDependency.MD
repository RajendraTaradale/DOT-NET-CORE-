
## Step 1 Install RequiredPackages
### NuGet package manager and install “Autofac” and “Autofac.Extensions.DependencyInjection” packages.

## Step 2 Configure Autofac
```
/* ServiceModules.cs file */
public class ServiceModules: Autofac.Module
{
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);
        builder.RegisterType<TestUserService>().As<ITestUserService>();
    }
}
```

```
 /* In startup.cs file - */
public IServiceProvider ConfigureServices(IServiceCollection services)
{
      services.AddControllers();


      var builder = new ContainerBuilder();
      builder.RegisterModule<ServiceModules>();
      builder.Populate(services);


       var container = builder.Build();
       return new AutofacServiceProvider(container);  
}
```

```
[Route("api/[controller]")]
[ApiController]
public class TestUserController : ControllerBase
{
   private readonly ITestUserService _testuserService;
   public UserController(ITestUserService testuserService)
   {
       _testuserService = testuserService;
   }
   [HttpGet]
   public ActionResult<string> Get()
   {
       return Ok(_userService.GetUserData());
   }
}
```

