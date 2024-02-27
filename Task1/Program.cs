void Main(){
  System.Console.WriteLine("Введите числа M и N");
  int m = Convert.ToInt32(Console.ReadLine());
  int n = Convert.ToInt32(Console.ReadLine());
  PrintDigits(m,n);
}

void PrintDigits(int start,int end){
  if (start<=end){
    System.Console.Write(start+" ");
    PrintDigits(start+1,end);
  }
}

Main();
