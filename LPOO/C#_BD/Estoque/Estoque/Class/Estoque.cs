using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque
{
    class Estoque_prod
    {
        public int _id_prod;//
        public string _nome;//
        public DateTime _dt_fabric;//
        public DateTime _dt_validade;//
        public double _preco;//
        public string _marca;//
        public int _id_estoq_prod;
    }

    class Estoque_Vend//
    {
        public int _id_ven;//
        public int _senha;//
        public string _nome_ven;//
        public string _endereco;//
        public double _salario_fixo;//
        public DateTime _dt_registro;//
        public int _tell;//
       // public Nullable<int> _id_vend_adm;
    }

    class Estoque_Ped//
    {
        public int _cod_ped;//
        public double _val_total;//
        public DateTime _dt_emis;//
        public double _cpf;//
        public int _id_ven_pedido;//
    }

    class Estoque_Clie//
    {
        public double _cpf;//
        public string _nome;//
        public string _endereco;//
        public DateTime _dt_nasci;//
        public int _situacao;//
        public int _telefone;//
    }

    class Estoque_relatorio
    {
        public DateTime _data1;
        public DateTime _data2;
    }

    class Estoque_Est
    {
        public int _id_estoq;
        public int _qtd_prod;
        public string _endereco;
        public string _area_armaz;
        public string _situacao_estoque;
    }
}
