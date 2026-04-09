static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        
        var KnightIsAwake = knightIsAwake;
        
        if(!KnightIsAwake)
        {            
            return true;
        }
       
        return false;
       
           
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        var KnightIsAwake = knightIsAwake;
        var ArcherIsAwake = archerIsAwake;
        var PrisonerIsAwake = prisonerIsAwake;

        if (KnightIsAwake || ArcherIsAwake || PrisonerIsAwake)
        {
            return true;
        }

        return false;

            
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        var ArcherIsAwake = archerIsAwake;
        var PrisonerIsAwake = prisonerIsAwake;

        if(PrisonerIsAwake && !ArcherIsAwake)
        {
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        var KnightIsAwake = knightIsAwake;
        var ArcherIsAwake = archerIsAwake;
        var PrisonerIsAwake = prisonerIsAwake;
        var PetDogIsPresent = petDogIsPresent;

        if(PetDogIsPresent)
        {
            if(!ArcherIsAwake)
            {
                return true;
            }
        }

        if(!PetDogIsPresent)
        {
            if(PrisonerIsAwake && (!ArcherIsAwake && !KnightIsAwake))
            {
                return true;
            }
        }
        return false;
    }
}
