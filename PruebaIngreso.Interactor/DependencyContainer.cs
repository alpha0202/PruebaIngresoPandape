using Microsoft.Extensions.DependencyInjection;
using PruebaIngreso.InputPort.RegistrarCandidatos;
using PruebaIngreso.Interactor.CandidatosInteractor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Interactor
{
    public static class DependencyContainer
    {
        public static IServiceCollection DependencyInteractor(this IServiceCollection services)
        {

            services.AddScoped<IGetAllCandidatesInputPort, GetAllCandidatesInteractor>();
            services.AddScoped<IGetDetailsCandidateInputPort, GetDetailsCandidateInteractor>();
            services.AddScoped<IDeleteCandidateInputPort, DeleteCandidateInteractor>();
            services.AddScoped<ISaveCandidateInputPort, SaveCandidateInteractor>();


            return services;
        }
    }
}
