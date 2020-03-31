import { Cidade } from "./cidade";

export class Estado{
    id: number;
    sigla: string;
    nome: string;
    cidades: Cidade[];
}