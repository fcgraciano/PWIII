namespace PW3.Entidades
{
    public class DisciplinaEntidade
    {
        /*
            CREATE TABLE DISCIPLINAS(
                Id INT PRIMARY KEY AUTO_INCREMENT,
                Nome VARCHAR(150) NOT NULL,
                Ativo BIT DEFAULT 1
            );
        */
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
