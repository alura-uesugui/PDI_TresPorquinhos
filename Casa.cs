class Casa {

   private static int qtdCasas = 1;
   public int Posicao { get; set; }
   public string Morador { get; set; }
   public string Material { get; set; }

   // Método construtor
   public Casa(string morador, string material)
   {
      this.Posicao = qtdCasas;
      this.Morador = morador;
      this.Material = material;

      qtdCasas++;
   }
   
}