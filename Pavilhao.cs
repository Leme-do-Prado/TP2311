public Pavilhao {
    Queue<Veiculo> veiculos;
    Queue<Visitante> filaEmbarque;
    const vlPorPassageiro = 5;

    public void checkIn(Visitante passageiro){
        passageiro.getInscricao();
        if(passageiro.validadeInscriçao == true){
            filaEmbarque.add(passageiro);
        }
    }

    public void embarcaVeiculo(Visitante passageiro, Veiculo veiculo){

    }

    public void pagaMotorista(){
        foreach (var veiculo in veiculos)
        i=1;
        {
            foreach(var passageiro in historicoPassageiros){
                veiculo.setFaturaMotorista((veiculo.getFaturaMotorista) + i*5);
                i++;
            }
        }
    }

}
