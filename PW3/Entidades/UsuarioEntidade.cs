namespace PW3.Entidades
{
    public class UsuarioEntidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        /*   
         CREATE TABLE USUARIOS (
            ID INT PRIMARY KEY AUTO_INCREMENT,
            NOME VARCHAR(80) NOT NULL,
            EMAIL VARCHAR(150) NOT NULL,
            SENHA VARCHAR(250) NOT NULL,
            ATIVO BIT DEFAULT 1
        );

        INSERT INTO usuarios (NOME, EMAIL, SENHA, ATIVO) VALUES ('Admin', 'admin@admin.com', '123456', true);

        */
    }
}
