namespace BetaC_API.Services;

using BetaC_API.Models;

public static class GenerationService
{
    static List<Generations> Gen { get; }
    static int nextId = 3;
    static GenerationService()
    {
        Gen = new List<Generations>
        {
            new Generations { Id = 1, Name = "SPECTRUM&NEOSPECTRUM", Active = false },
            new Generations { Id = 2, Name = "NeoNext SPECTRUM", Active = true }
        };
    }

    public static List<Generations> GetAll() => Gen;

    public static Generations? Get(int id) => Gen.FirstOrDefault(p => p.Id == id);

    public static void Add(Generations gen)
    {
        gen.Id = nextId++;
        Gen.Add(gen);
    }

    public static void Delete(int id)
    {
        var gen = Get(id);
        if(Gen is null)
            return;

        Gen.Remove(gen);
    }

    public static void Update(Generations Generation)
    {
        var index = Gen.FindIndex(p => p.Id == Gen.Id);
        if(index == -1)
            return;

        Gen[index] = Generation;
    }
}