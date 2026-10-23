using System;

namespace ProjetoAnimais.Models
{
    public class Emergencia
    {
      
        public int Id { get; set; }            
        public string Checklist { get; set; }  
        public int AnimalId { get; set; }      

        public Emergencia()
        {
        }
        public Emergencia(int id, string checklist, int animalId)
        {
            Id = id;
            Checklist = checklist;
            AnimalId = animalId;
        }
        public void ExibirEmergencia()
        {
            Console.WriteLine($"=== EMERGÊNCIA ID: {Id} ===");
            Console.WriteLine($"Animal ID: {AnimalId}");
            Console.WriteLine($"Checklist: {Checklist}");
        }
    }
}
