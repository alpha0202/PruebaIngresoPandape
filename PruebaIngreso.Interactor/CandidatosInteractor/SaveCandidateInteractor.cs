using PruebaIngreso.Entities;
using PruebaIngreso.InputPort.RegistrarCandidatos;
using PruebaIngreso.OutputPort.SalidaCandidatos;
using PruebaIngreso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaIngreso.Interactor.CandidatosInteractor
{
    public class SaveCandidateInteractor : ISaveCandidateInputPort
    {
        private readonly ICandidatesRepository _candidatesRepository;
        private readonly ISaveCandidateOutputPort _outputPortSave;

        public SaveCandidateInteractor(ICandidatesRepository candidatesRepository, ISaveCandidateOutputPort outputPortSave)
        {
            _candidatesRepository = candidatesRepository;
            _outputPortSave = outputPortSave;
        }

        public async void Handler(Candidate candidate)
        {
            bool resSave;
            try
            {
                if (candidate.Id == 0)
                {
                    await _candidatesRepository.SaveCandidate(candidate);
                    resSave=true;
                }
                else
                {
                    await _candidatesRepository.UpdateCandidate(candidate);

                    resSave=true;
                }

            }
            catch (Exception ex)
            {
                resSave=false;
                throw new Exception(ex.Message);
            }
            _outputPortSave.Handler(resSave);


            //bool resSave = await _candidatesRepository.SaveCandidate(candidate);
            //_outputPortSave.Handler(resSave);

        }
    }
}
