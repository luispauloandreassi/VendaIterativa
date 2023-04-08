using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Venda.Iterativa.Classes;


namespace Venda.Iterativa.Model
{
    internal sealed class PedidoModel : AbstractModel
    {
        private ObservableCollection<ProdutoModel> _produtos
            = new ObservableCollection<ProdutoModel>();
        private decimal _total = 0.00m;
        private long _numeroCartao;
        private DateTime _dataValidadeCartao = DateTime.Today;
        private int _cvv;

        public ObservableCollection<ProdutoModel> Produtos 
        {
            get => _produtos;
            set => SetField(ref _produtos, value);
        }

        public decimal Total
        {
            get => _total;
            set=> SetField(ref _total, value);
        }


        public long NumeroCartao
        {
            get => _numeroCartao;
            set => SetField(ref _numeroCartao, value);

            
        }


        public DateTime DataValidade
        {
            get => _dataValidadeCartao;
            set => SetField(ref _dataValidadeCartao, value);
        }



        public int Cvv
        {
            get => _cvv;
            set => SetField(ref _cvv, value);
        }





    }
}