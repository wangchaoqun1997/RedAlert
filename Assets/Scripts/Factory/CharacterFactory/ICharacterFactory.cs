using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public interface ICharacterFactory {
    ICharacter CreateCharacter(string characterName);
}