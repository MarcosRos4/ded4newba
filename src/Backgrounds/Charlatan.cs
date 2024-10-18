using ded4newba.Src.PassiveHabilities;
using ded4newba.Src.Backgrounds;
using ded4newba.src.Habilities;

namespace ded4newba.src.Backgrounds
{
    public class Charlatan : Background
    {
        readonly private PassiveHability disguisekit = new(
            "Disguise Kit",
            "This pouch of cosmetics, hair dye, and small props lets you create disguises"+
            " that change your physical appearance. Proficiency with this kit lets you ad"+
            "d your proficiency bonus to any ability checks you make to create a visual d"+
            "isguise."
        );

        readonly private PassiveHability forgerykit = new(
            "Forgery Kit",
            "This small box contains a variety of papers and parchments, pens and inks, "+
            "seals and sealing wax, gold and silver leaf, and other supplies necessary t"+
            "o create convincing forgeries of physical documents. Proficiency with this "+
            "kit lets you add your proficiency bonus to any ability checks you make to c"+
            "reate a physical forgery of a document."
        );

        readonly private PassiveHability falseidentity = new(
            "False Identity",
            "You have created a second identity that includes documentation, establishe"+
            "d acquaintances, and disguises that allow you to assume this persona. Addi"+
            "tionally, you can forge documents, including official papers and personal "+
            "letters, as long as you have seen an example of the kind of document or th"+
            "e handwriting you are trying to copy."
        );
        
        readonly Skill Prestidigitation = new(
            "Prestidigitation",
            "Dexterity",
            true,
            false
        );

        readonly Skill Deception = new(
            "Deception",
            "Charisma",
            true,
            false
        );

        readonly Skill Disguise = new(
            "Disguise",
            "Charisma",
            true,
            false
        );

        readonly Skill Forgery = new(
            "Forgery",
            "Dexterity",
            true,
            false
        );

        public Charlatan(){
            
            KnownSkills.Add(Prestidigitation);
            KnownSkills.Add(Deception);
            KnownSkills.Add(Disguise);
            KnownSkills.Add(Forgery);
            
            PassiveHabilities.Add(disguisekit.Name, disguisekit.Description);
            PassiveHabilities.Add(forgerykit.Name, forgerykit.Description);
            PassiveHabilities.Add(falseidentity.Name, falseidentity.Description);
        }
    }
}