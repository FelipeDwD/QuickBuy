﻿using Dwd.Lab.Dominio.Contratos;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Linq;

namespace Dwd.Lab.Dominio.Entidades
{
    public class Imagem : IImagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        private IHostingEnvironment _hostingEnvironment;

        private IHttpContextAccessor _httpContextAccessor;

        public string EnviarParaServidor()
        {
            //Arquivo recebido como um todo
            var formFile = this._httpContextAccessor.HttpContext.Request.Form.Files["arquivoEnviado"];

            //Nome fo arquivo recebido
            var nomeArquivo = formFile.FileName;

            //Guarda a extensão do arquivo, último(s) caractere(s) depois do último "."
            var extensao = nomeArquivo.Split(".").Last();

            //Guarda os primeiros 10 caracteres que está em "nome"
            var arrayNomeCompacto = Path.GetFileNameWithoutExtension(nomeArquivo).Take(10).ToArray();

            //Guarda os primeiros caracteres do arquivo trocando ""(espaço) por "-"(traço), adiciona ".(extensao)".
            var novoNomeArquivo = new String(arrayNomeCompacto).Replace(" ", "-") + "." + extensao;

            //Endereço da pasta onde irá ser criado o arquivo no servidor
            var pastaArquivos = this._hostingEnvironment.WebRootPath + @"\arquivos\";

            //Guarda o novo nome completo do arquivo (Caminho + novo nome)
            var nomeCompleto = pastaArquivos + novoNomeArquivo;

            using (var streamArquivo = new FileStream(nomeCompleto, FileMode.Create))
            {
                formFile.CopyTo(streamArquivo);
            }

            return novoNomeArquivo;
        }
    }
}
