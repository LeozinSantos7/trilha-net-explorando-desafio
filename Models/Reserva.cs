namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }
        public int QuantidadeDeHospedes { get; set; }


        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // *IMPLEMENTADO*
            if (Suite.Capacidade >= ObterQuantidadeHospedes())// verificar, "Suite.Capacidade" é maior ou igual ao meu metodo "ObterQuantidadeHospedes()"? caso a condição for verdadeira iniciará. Caso seja falsa irá me retornar uma exceção
            {
                Hospedes = hospedes;
            }
            else
            {
                // *IMPLEMENTADO* Caso a condição for falsa retorna uma Exceção
                throw new Exception("A capacidade de hóspedes não pode exceder a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // *IMPLEMENTADO AQUI*
            QuantidadeDeHospedes = 12; //Quantidade de Hospedes!
            return QuantidadeDeHospedes; //Retorna a quantidade de Hospedes!
            
        }

        public decimal CalcularValorDiaria()
        {
            // *IMPLEMENTADO AQUI*
            decimal valor = 0;
            valor = DiasReservados * Suite.ValorDiaria; //Calculo do valor geral
            // *IMPLEMENTADO AQUI*
            if (DiasReservados >= 10) // Aqui está verificando. DiasReservados é maior ou igual a 10? Se a condição for verdadeira, ganhará 10% de desconto!
            {
                valor -= valor * 0.10m; // Calculo com 10% de desconto
                /*
                    Calculo aplicado com desconto.
                    Explicação: Estou pegando minha variavel "valor", é estou subtraindo "valor - valor", multiplicada por 0,10 que é 10%
                    minha variável, "valor" é atribuída o resultado da multiplicação, de DiasReservados x Suite.ValorDiaria.
                    Com o resultado da multiplicação atribuida no valor, agora irei subtrair por ela mesma sendo assim.
                    valor -= valor x 0.10 = 270.
                    no momento em que chamo minha variável valor, ela está armazenando o valor 300 pois DiasReservados = 10 ValorDiaria = 30.
                    Então 30 x 10 = 300, é valor x 0.10 = 30 sendo assim 300 - 30 = 270 
                    obs: valor é = 300 por isso, valor x 0.10 = 30!
                */

            }

            return valor;
        }
    }
}