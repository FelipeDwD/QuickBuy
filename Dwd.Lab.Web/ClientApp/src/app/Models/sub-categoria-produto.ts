import { CategoriaProduto } from "./categoria-produto";

export class SubCategoriaProduto{
    id: number;
    idCategoriaProduto: number;
    nome: string;
    descricao: string;
    categoriaProduto: CategoriaProduto;
}