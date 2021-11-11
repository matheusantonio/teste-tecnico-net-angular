export class PaginatedList<T> {

    public pagina: number = 0;
    public limite: number = 5;
    public total: number = 0;
    public itens: Array<any>;

    constructor(pagina: number = 0, limite: number = 5) {
        this.pagina = pagina;
        this.limite = limite;
        
        this.itens = [];
    }

    public load(data: any) {
        this.pagina = data.pagina;
        this.limite = data.limite;
        this.total = data.total;
        this.itens = data.itens;
    }

    public next() : void {
        if((this.pagina == 0 ? 1 : (this.pagina + 1)) * this.limite < this.total) {
            this.pagina++;
        }
    }

    public previous() : void {
        if(this.pagina > 0) {
            this.pagina--;
        }
    }

    public clear() : void {
        this.pagina = 0;
        this.itens = [];
    }

}