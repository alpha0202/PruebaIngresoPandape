using Microsoft.Extensions.DependencyInjection;
using PruebaIngreso.OutputPort.SalidaCandidatos;
using PruebaIngreso.Presenter.Candidate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Presenter
{
    public static class DependencyContainer
    {

        public static IServiceCollection DependencyPresenter(this IServiceCollection services)
        {
            services.AddScoped<IGetAllCandidatesOutputPort, GetAllCandidatePresenter>();
            services.AddScoped<IGetDetailsCandidateOutputPort, GetDetailCandidatePresenter>();
            services.AddScoped<IDeleteCandidateOutputPort, DeleteCandidatePresenter>();
            services.AddScoped<ISaveCandidateOutputPort, SaveCandidatePresenter>();
            
            return services;
        }

    }
}
