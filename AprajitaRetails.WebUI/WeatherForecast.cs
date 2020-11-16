using System;

namespace AprajitaRetails.WebUI
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
}
/*
 Helper 

https://developer.okta.com/blog/2018/07/02/build-a-secure-crud-app-with-aspnetcore-and-react
https://www.ego-cms.com/post/asp-net-core-webpack-react
https://dzone.com/articles/aspnet-core-crud-with-reactjs-and-entity-framework
https://docs.microsoft.com/en-us/visualstudio/containers/container-tools-react?view=vs-2019

https://codesandbox.io/s/4j7m47vlm4
 
 */