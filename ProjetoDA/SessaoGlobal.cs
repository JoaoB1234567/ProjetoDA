namespace ProjetoDA
{
    // Esta classe guarda os dados do utilizador enquanto o programa está aberto
    public static class SessaoGlobal
    {
        // O Id do utilizador deve ser guardado durante a execução da aplicação
        public static int UtilizadorLogadoId { get; set; }

        public static string UtilizadorLogadoNome { get; set; }
    }
}