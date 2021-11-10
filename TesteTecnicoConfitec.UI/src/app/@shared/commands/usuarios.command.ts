export class RegistrarUsuario {
    private nome : string;
    private sobrenome : string;
    private email : string;
    private dataDeNascimento : Date;
    private escolaridade : number;

    constructor(usuario : any) {
        this.nome = usuario.nome;
        this.sobrenome = usuario.sobrenome;
        this.email = usuario.email;
        this.dataDeNascimento = usuario.dataDeNascimento;
        this.escolaridade = usuario.escolaridade;
    }
}

export class AlterarUsuario extends RegistrarUsuario {
    private id : number;

    constructor(usuario : any) {
        super(usuario);
        this.id = usuario.id;
    }
}