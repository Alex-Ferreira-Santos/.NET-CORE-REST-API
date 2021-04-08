using System.Collections.Generic;

namespace TesteWS.models
{
    public class BDMock
    {
        private static List<Produto> _listaProdutos = null;
        public static List<Produto> Produtos{
            get{
                if(_listaProdutos == null){
                    _listaProdutos = new List<Produto>(){
                        new Produto(){Id=1,Descrição="Tênis",Preco=10,Novo=false},
                        new Produto(){Id=2,Descrição="Camiseta",Preco=20.50m,Novo=true},
                        new Produto(){Id=3,Descrição="Camisa",Preco=25,Novo=false},
                        new Produto(){Id=4,Descrição="Fone de Ouvido",Preco=30,Novo=true},
                        new Produto(){Id=5,Descrição="Mouse",Preco=40.99m,Novo=true}
                    };
                }
                return _listaProdutos;
            }
        }
    }
}