namespace _06_ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF
        {
            get
            {
                return _cpf;
            }

            set
            {
                // minha lógica aqui
                _cpf = value;
            }
        }
        public string Profissao { get; set; }
    }

}

