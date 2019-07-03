namespace CxxDemangler {

class TestClass
{
    static void Main(string[] args)
    {
        if (args.Length == 0) {
		System.Console.WriteLine("Example demangling:");
		System.Console.WriteLine(CxxDemangler.Demangle("_ZTVSt15_Sp_counted_ptrIPiLN9__gnu_cxx12_Lock_policyE2EE"));
		System.Console.WriteLine(CxxDemangler.Demangle("_ZTVSt16_Sp_counted_baseILN9__gnu_cxx12_Lock_policyE2EE"));
		System.Console.WriteLine(CxxDemangler.Demangle("_ZTVSt23_Sp_counted_ptr_inplaceIiSaIiELN9__gnu_cxx12_Lock_policyE2EE"));
	} else {
		System.Console.WriteLine(CxxDemangler.Demangle(args[0]));
	}
    }
}

}
