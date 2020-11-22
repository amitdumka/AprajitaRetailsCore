using AprajitaRetails.DL.Data;
using AprajitaRetails.Shared.Models.Indentity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Buffers;
using System.Buffers.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace AprajitaRetails.API
{
    //public class NullableDateTimeToString : JsonConverter<DateTime?>
    //{
    //    public override DateTime? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    //    {
    //       // Console.WriteLine("Reading");
    //        Debug.Assert(typeToConvert == typeof(DateTime?));
    //        return reader.GetString() == "" ? null : reader.GetDateTime();
    //    }

    //    // This method will be ignored on serialization, and the default typeof(DateTime) converter is used instead.
    //    // This is a bug: https://github.com/dotnet/corefx/issues/41070#issuecomment-560949493
    //    public override void Write(Utf8JsonWriter writer, DateTime? value, JsonSerializerOptions options)
    //    {
    //        //Console.WriteLine("Here - writing");

    //        if (!value.HasValue)
    //        {
    //            writer.WriteStringValue("");
    //        }
    //        else
    //        {
    //            writer.WriteStringValue(value.Value);
    //        }
    //    }
    //}
    //public class LongToStringConverter : JsonConverter<long>
    //{
    //    public override long Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType == JsonTokenType.String)
    //        {
    //            // try to parse number directly from bytes
    //            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
    //            if (Utf8Parser.TryParse(span, out long number, out int bytesConsumed) && span.Length == bytesConsumed)
    //                return number;

    //            // try to parse from a string if the above failed, this covers cases with other escaped/UTF characters
    //            if (Int64.TryParse(reader.GetString(), out number))
    //                return number;
    //        }

    //        // fallback to default handling
    //        return reader.GetInt64();
    //    }

    //    public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }
    //}
    //public class IntToStringConverter : JsonConverter<int>
    //{
    //    public override int Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    //    {
    //        if (reader.TokenType == JsonTokenType.String)
    //        {
    //            ReadOnlySpan<byte> span = reader.HasValueSequence ? reader.ValueSequence.ToArray() : reader.ValueSpan;
    //            if (Utf8Parser.TryParse(span, out int number, out int bytesConsumed) && span.Length == bytesConsumed)
    //            {
    //                return number;
    //            }

    //            if (int.TryParse(reader.GetString(), out number))
    //            {
    //                return number;
    //            }
    //        }

    //        return reader.GetInt32();
    //    }

    //    public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
    //    {
    //        writer.WriteStringValue(value.ToString());
    //    }
    //}
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
             services.AddControllers();
            //services.AddControllers()
            // .AddJsonOptions(options =>
            // {
            //     options.JsonSerializerOptions.Converters.Add(new IntToStringConverter());
            //     options.JsonSerializerOptions.Converters.Add(new LongToStringConverter());
            //     options.JsonSerializerOptions.Converters.Add(new NullableDateTimeToString());

            // });
                services.AddDbContext<AprajitaRetailsContext>(options =>
               options.UseSqlServer(
                   Configuration.GetConnectionString("DefaultConnection")));
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Aprajita Retails ERP API",
                    Description = "Apraita Retails ERP Api for web and mobile app.",
                    TermsOfService = new Uri("https://www.aprajitaretails.in/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Amit Kumar",
                        Email = "amitnarayansah@gmail.com",
                        Url = new Uri("https://twitter.com/amitdumka"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://aprajitaretails.in/license"),
                    }
                });
            });
            //services.AddDefaultIdentity<AppUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //     .AddRoles<IdentityRole>()
            //    .AddEntityFrameworkStores<AprajitaRetailsContext>();
            services.AddDistributedMemoryCache();
            //services.AddAuthorization(options =>
            //{
            //    options.FallbackPolicy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //});
            ////services.AddControllers(config =>
            //{
            //    // using Microsoft.AspNetCore.Mvc.Authorization;
            //    // using Microsoft.AspNetCore.Authorization;
            //    var policy = new AuthorizationPolicyBuilder()
            //                     .RequireAuthenticatedUser()
            //                     .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("https://localhost:44348").AllowAnyHeader().AllowAnyMethod();
                                  });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseCors(MyAllowSpecificOrigins);
            //app.UseAuthentication(); 
            //app.UseAuthorization();

            // app.UseSession();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            //app.UseSwagger(c =>
            //{
            //    c.SerializeAsV2 = true;
            //});

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Aprajita Retails ERP V5.0");
                c.RoutePrefix = string.Empty;
                //c.InjectStylesheet("/swagger-ui/custom.css");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
