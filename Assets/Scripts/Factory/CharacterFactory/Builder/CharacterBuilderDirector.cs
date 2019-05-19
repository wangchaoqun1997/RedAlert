using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CharacterBuilderDirector {
    public static ICharacter Construct(ICharacterBuilder builder) {
        builder.AddCharacterAttr();
        builder.AddGameObject();
        builder.AddWeapon();
        return builder.GetResult();
    }
}
