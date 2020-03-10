import { SubCategoriaProduto } from "./sub-categoria-produto";

export class CategoriaProduto{
    id: number;
    nome: string;
    descricao: string;
    subCategoriasProduto: SubCategoriaProduto[];
}