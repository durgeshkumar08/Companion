using Companion.Bll.PersonManagement;
using Companion.Persistance;
using Companion.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Companion.Config
{
    public class UnityConfig
    {
        public static void InitializeUnityConifg(IServiceCollection services)
        {
            //services.AddSingleton<>
            services.AddScoped<IPersonBll, PersonBll>();
            services.AddScoped<IPersonRepository, PersonRepository>();

        }
    }
}
