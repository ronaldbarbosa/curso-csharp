namespace classes_atributos_metodos {
    public class Retangulo {
        private double largura;
        private double altura;

        public Retangulo(double largura, double altura) {
            this.largura = largura;
            this.altura = altura;
        }

        public double Area() {
            return this.altura * this.largura;
        }

        public double Perimetro() {
            return 2 * (this.altura + this.largura);
        }

        public double Diagonal() {
            return Math.Sqrt(Math.Pow(this.altura, 2) + Math.Pow(this.largura, 2));
        }
    }
}