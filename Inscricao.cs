public Inscricao{
    int numInscricao {get ; set;};
    bool validadeInscricao {get ; set;};

    Inscricao(int numInscricao, bool validadeInscricao){
        this.numInscricao = numInscricao;
        this.validadeInscricao = validadeInscricao;
    }
}
