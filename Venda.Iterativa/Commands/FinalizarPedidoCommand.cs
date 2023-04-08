using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using Venda.Iterativa.Classes;
using Venda.Iterativa.ViewModel;

namespace Venda.Iterativa.Commands
{
    internal sealed class FinalizarPedidoCommand : AbstractCommand
    {
        public override void Execute(object? parameter)
        {
            var vm = parameter as ReceberViewModel;


            if (vm.Pedido.NumeroCartao.ToString().Length != 16 || !(vm.Pedido.NumeroCartao is long))
            {
                MessageBox.Show("O Numero Informado não é Válido!\nA Quantidade de dígitos não é 16 ou o valor informado contém Letras!");
                return;
            }        

            if (vm.Pedido.DataValidade < DateTime.Today)
            {
                MessageBox.Show("Data de Validade menor que o dia atual");
                return;
            }

            if (vm.Pedido.Cvv.ToString().Length != 3)
            {
                MessageBox.Show("Informe um CVV válido");
                return;
            }

            MessageBox.Show("Pedido Finalizado com sucesso!!!");

        }
    }
}
