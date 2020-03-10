import { CategoriaProduto } from "./categoria-produto";
import { SubCategoriaProduto } from "./sub-categoria-produto";

export class Produto {
    id: number;
    codigoLoja: string;
    nome: string;
    descricao: string;
    preco: number;
    categoriaProduto: CategoriaProduto;
    subCategoriaProduto: SubCategoriaProduto;

}