# csharp-webdriver-parallel-framework

This is a basic bootstrap for Parallelised WebDriver testing with C#

## Aim

The Framework and Test projects should be separated, with all possible parallelisation scaffolding and driver management contained within the Framework.  
The Test project should only be required to have knowledge of the tests & system under test, while retaining the capability to define it's own parallelisation options.' 

## CLI

Something along the lines of

```
"C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\CommonExtensions\Microsoft\TestWindow\vstest.console.exe" .\test\Web.Tests\bin\Debug\netcoreapp2.1\Web.Tests.dll /Settings:.\test\Web.Tests\default.runsettings
```

### TODO

- Add in a Saucelabs Driver
- Performance test Worker count variability
- Add in CLI/Pipeline usage
- Add in Categorisation examples
- Add in Config rewrite sentinels
- Add in X-Browser specifications (e.g. | Run All | In Chrome latest | In Firefox latest | In Edge latest |)