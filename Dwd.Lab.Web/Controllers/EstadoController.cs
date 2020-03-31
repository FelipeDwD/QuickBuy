using AutoMapper;
using Dwd.Lab.Dominio.Contratos;
using Dwd.Lab.Dominio.Entidades;
using Dwd.Lab.Web.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dwd.Lab.Web.Controllers
{
    [Route("api/[Controller]")]
    public class EstadoController : Controller
    {
        private readonly IEstadoRepositorio _estadoRepositorio;
        

        public EstadoController(IEstadoRepositorio estadoRepositorio)
        {
            this._estadoRepositorio = estadoRepositorio;
        }

        [HttpPost]
        public IActionResult Save([FromBody] List<Estado> estados)
        {
            try
            {
                foreach (Estado estado in estados)
                {
                    this._estadoRepositorio.Adicionar(estado);
                }

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
        }

        [HttpGet]
        public ActionResult<List<EstadoViewModel>> GetSelectList()
        {
            try
            {
                // Items e uma lista de Estados (Entidade)
                // como a ideia e nao retornar a entidade eu coloquei no metoo que ele vai retornar uma Lista de EstadoViewModel
                // e fiz esse Mapper pra converrter de Estado para EstadoViewModel
                // e retornei ele, e no metodo e importante deixar tipado o que ele vai retornar no caso
                // Enumerable de <EstadoViewmodel>
                // o restante das coisas que fiz foi uma configracao do AutoMapper, 
                // e sempre que vc for precisar mapear uma nova entidade furutamente e aqui que deve ser feito 
                var items = this._estadoRepositorio.RetornarTodos();

                // Pra mapear uma lista pra outra, eu fiz o Map<IEnumerable<ClasseQUeQueroMapear>>(ORigemDosDados);
                // se fosse mapear de um obj pra outro seria
                //var ret = Mapper.Map<EstadoViewModel>(items);
                // Recomendo que aplique esse metodo nos outros controllers que ja tem funcionando e crie as respecivas
                // Viewmodels aah e tb nao espere nunca no metodo receber a Entidade, sempre receba a VM por ex:
                // public IActionResult Save([FromBody] List<EstadoViewModel> estados)
                // e como vai chegar a VM pra vc mandar salvar ou algo do tipo que precisa ser o obj Natural,
                // ou voce pega os dados que chegou e da um New na entidade e cria ela e manda salvar(forma correta)
                // ou vc faz isso via AutoMapper pra mapear da ViewModel para Model(correta, mas nao tanto)
                //e tb, pegue o habito de tipar o retorno do metodo deixando nessa ideia, se quiser e claro.. so uma dica
                // public ActionResult<EstadoViewModel> Save([FromBody] List<EstadoViewModel> estados)
                // bom, acho que e isso !
                // caramba kkk que aula mano...! vou ir atrás disso tudo sim, e começar refatorar aplicando
                //so vai, mais algo?
                //nada kkkk depois dessa, tenho que ficar um mes calado kkkkk
                //tranquilo brow, eu tava num b.o aqui no sistema tava meio bolado, aqui ja me ajudou a esfriar a mente pra pensar kkk 
                //b.o de lógica ou estrutura tipo o meu?
                // pensando em um Pattern pra resolver um b.o que to querendo melhorar, tenho uma classe com alguns dispositivos
                // e cada um tem uma regra de implmentacao entao sempre que add um disp novo eu tenho que ir e criar um else if novo
                // porem isso e inviavel total, num sistema de medio/grande porte, entao to estudando qual patterns resolveria,
                //melhor minha situacao e o pq! kk 
                //eu aprendi isso no solid, que não deve msm, mas n manjo mt né, só li msm
                //aham, solid faz parte de tudo que e pra deixar num conceito melhor, mas nesse caso tenho que aplicar outro tipo
                // de pattern, solid e conceito pattern seria a estrutura mesmo
                // entendeu, slc... tenho muito ainda a pesquisar hj e amanha kkk quero aprender e fixar sobre usar mapper
                //segue isso ae que escrevi de padroes e aplica igual fiz nesse mtodo, que vc vai ver que e simples dps de fazer 2 x
                // so tem qu elembrar de declarar o mapeamento na classe dele(eu sempre esqueco, so lembro hora que quebra a aplicacao com o erro)
                // kkkkkk normal
                //mas segue ae, a configuracao dele eu ja fiz nao vai precisar alterar + somente add novos mapeamentos quando necessario
                // qualquer duvida na hora de voltar da VM pra entidade via Ctor ou mappers, so falar, mas ctz que vai conseguir izi
                // vou atrás disso hj msm mano, que já ta fresco, vc aprendeu em algum material? ou te passaram igual vc fez cmg, um pouco de cada 
                // demorou, valeu mesmo pela aula slc mano, adiantou demais aqui... vou praticar já
                // so vai, !!! mas geralmente essas coisas aprende basntate em foruns, calls em grupos de wpp e talz, disso ae acho que .. bom acho que meio que nada alguem  me passou, sao mais conceitos mesmos, mas claro sempre aprendemos com alguem, isso e normal na net ou pessoalmente ainda e alguem ensinando kk
                // sim, mas msm da forma que foi adiantou mt..valeu mesmo mano, pela força e pelo apoio
                //tranquilo, vai la, evolua! fui 

                var ret = Mapper.Map<List<EstadoViewModel>>(items);

                if (items == null)
                {
                    return BadRequest("Nenhum estado");
                }
                return Ok(ret);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message.ToString());
            }
        }

    }
}
