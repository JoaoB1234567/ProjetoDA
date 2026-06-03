namespace ProjetoDA.Controllers {
    public class LoginController {
        public bool ValidarLogin(string username, string password) {
            if (username == "admin" && password == "1234") {
                // Agora já não deve aparecer o erro vermelho aqui
                SessaoGlobal.UtilizadorLogadoId = 1;
                SessaoGlobal.UtilizadorLogadoNome = username;
                return true;
            }
            return false;
        }
    }
}