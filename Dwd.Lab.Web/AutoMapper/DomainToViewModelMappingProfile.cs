using AutoMapper;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Web.ViewModel;

namespace Dwd.Lab.Web.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            // Aqui dentro que deve ser feito o mapeamento  e o metodo ReverseMap e pra dizer pro AutoMapper
            // que eu quero que ele faca o mapping tanto da Entidade pra ViewModel quanto da ViewModel pra Entidade
            // enntao aqui ja fiz de Estado e Cidade
            // Pergunta 1: pq eu fiz na cidade sendo que so trabalhei com a entidade de Estado
            // Resp: pq dentro do Estado tem uma lista de Cidade, entao precisei mapear tb, se nao daria erro
            // OBS: dentro da viewModels, referencie sempre outras VM(ViewModel) olha so
            // Dentro da VM referencia VM dentro do Model Referencia Model(Entidade)                     
            CreateMap<Estado, EstadoViewModel>().ReverseMap();
            CreateMap<Cidade, CidadeViewModel>().ReverseMap();
            CreateMap<Usuario, UsuarioCadastroViewModal>().ReverseMap();
        }
    }
}
