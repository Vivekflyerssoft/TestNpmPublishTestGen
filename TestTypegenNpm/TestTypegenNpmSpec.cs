using TypeGen.Core.SpecGeneration;

namespace TestTypegenNpm;

public class TestTypegenNpmSpec: GenerationSpec
{
    public TestTypegenNpmSpec()
    {
        AddInterface<TestDto>();
    }

}
