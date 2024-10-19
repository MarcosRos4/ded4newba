using ded4newba.Src.Backgrounds;

namespace ded4newba.src.Backgrounds.Charlatan
{
    public class Charlatan : Background
    {
        public Charlatan(){
            
            KnownSkills.AddRange([
                new
                (
                    "Prestidigitation",
                    "Dexterity",
                    true,
                    false
                ),
                new
                (
                    "Deception",
                    "Charisma",
                    true,
                    false
                ),
                new
                (
                    "Disguise",
                    "Charisma",
                    true,
                    false
                ),
                new
                (
                    "Forgery",
                    "Dexterity",
                    true,
                    false
                )
            ]);
            
            PassiveHabilities.AddRange([
                new(
                    "Disguise Kit",
                    "This pouch of cosmetics, hair dye, and small props lets you create disguises"+
                    " that change your physical appearance. Proficiency with this kit lets you ad"+
                    "d your proficiency bonus to any ability checks you make to create a visual d"+
                    "isguise."
                ),
                new(
                    "Forgery Kit",
                    "This small box contains a variety of papers and parchments, pens and inks, "+
                    "seals and sealing wax, gold and silver leaf, and other supplies necessary t"+
                    "o create convincing forgeries of physical documents. Proficiency with this "+
                    "kit lets you add your proficiency bonus to any ability checks you make to c"+
                    "reate a physical forgery of a document."
                ),
                new(
                    "False Identity",
                    "You have created a second identity that includes documentation, establishe"+
                    "d acquaintances, and disguises that allow you to assume this persona. Addi"+
                    "tionally, you can forge documents, including official papers and personal "+
                    "letters, as long as you have seen an example of the kind of document or th"+
                    "e handwriting you are trying to copy."
                )
            ]);
        }
    }
}