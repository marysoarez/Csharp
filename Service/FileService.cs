using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prova.Service
{
    public class FileService
    {
        //endereço do XML
        const string xmlFile = @"C:\Users\McPlus\Downloads\pedidos.xml";

        public static List<PedidoDeVendaViewModel> XmlReader()
        {
            List<PedidoDeVendaViewModel> models = new List<PedidoDeVendaViewModel>();

            XDocument xml = XDocument.Load(xmlFile);
            var childNodes = xml.Root.Descendants();

            foreach (var item in childNodes)
            {
                PedidoDeVendaViewModel model = new PedidoDeVendaViewModel();
                model.Cliente = (string)item.Attribute("Cliente").Value;
                model.Pedido = int.Parse(item.Attribute("Pedido").Value);
                model.Data = DateTime.Parse(item.Attribute("Data").Value);
                model.Preco = decimal.Parse(item.Attribute("Total").Value);

                var produtos = item.Descendants("Produtos").ToList();
                foreach (var prod in produtos)
                {
                    Produto produto = new Produto();
                    produto.CodProduto = prod.Attribute("Codigo").Value;
                    produto.NomeProduto = prod.Attribute("Nome").Value;
                    produto.Quantidade = int.Parse(prod.Attribute("Quantidade").Value);
                    produto.Valor = decimal.Parse(prod.Attribute("Valor").Value);
                    model.Produtos.Add(produto);
                }
                models.Add(model);

            }

            return models;
        }

        public static GravarJson(Json payload)
        {
            try
            {
                var jsonToWrite = JsonConvert.SerializeObject(pedido, Formating.Indented);
                using(var writer=new StreamWriter(_path))
                { 
                    writer.Write(jsonToWrite);
                }
            }
            catch (Exception ex)
            { }
}

    }
}
