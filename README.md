esi
===

esiiiiii


Mini Tutorial de utilização do git:

em modo bash: (git bash nop cmd)

para iniciar uma pasta (para fazer qualquer coisa tem que criar o .git) (caractere $ indica o comando, nao incluir) navegando pelo gitbash ate a pasta digite:

$ git init <NOMEDAPASTAOPCIONAL>

se colocar o nome da pasta ele cria a pasta automatico

então é possível fazer : commit, push, pull, clone, etc

explicação ordenada: Após criar iniciar uma pasta com o .git (git init) é necessário baixar as info e o projeto do site com o seguinte comando:

$ git pull git@github.com:usuario/git.git

$ git pull git@github.com:merovigiam/esi.git

então é necessário criar um branch

explicação de branch: branch é a criação de um ramo do código original. será atravez dele que poderemos efetivamente utilizar as funcionalidades de:

-> altera código -> envia proposta de alterações -> pendencia de merge aparece para o administrador -> administrador efetiva a alteração do código (inserção (merge) das alterações propostas no código raiz)

para criar um branch:

$ git checkout -b NOMEBRANCHounomberanch

isto fará o serviço, então basta abrir no visual studio e fazer a festa. quando terminar ou quiser enviar a qualquer momento para o site as alterações é necessário que seu código seja efetivado (commit), pelo seguinte comando:

$ git commit -a -m "mensagem opcional, mas sempre coloque qualquer coisa"

não colocar a mensagem faz abrir um editor de texto que eu não sei utilizar, buga tudo... efetivado o codigo localmente (alterações) é necessário então enviar estas alterações para o servidor pelo comando:

Se for um branch:

$ git push git@github.com:merovigiam/esi.git NOMEBRANCHounomberanch

senão para a raiz:

$ git push git@github.com:merovigiam/esi.git

ele pedirá sua senha, então voilá, seu código NO MESMO INSTANTE no site. Assim será criado o branch para o código original e eu vou aprovar as coisas. não sei se posso delegar esta funcionalidade.


os plugins que foram instalados propiciam mais facilidade que executar linhas de comando.

bonus:

deletando uma branch no site: $ git push git@github.com:merovigiam/trapo.git :aloha (excluido já)