using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace LoopTestDotNet7
{



    [SimpleJob(RuntimeMoniker.Net70)]
    [MemoryDiagnoser(false)]
    public class Benchmarks
    {
        private List<int> ItemsList;

        [GlobalSetup]
        public void Setup()
        {
            var random = new Random(420);
            var randomItems = Enumerable.Range(0, 1000).Select(_ => random.Next());
            ItemsList = randomItems.ToList();
        }


        [Benchmark]
        public void ForEach_List()
        {
            foreach (var item in ItemsList)
            {
            }
        }
    }
    }
