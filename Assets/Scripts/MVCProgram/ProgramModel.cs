using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramModel {

    public enum ProgramInstructionType{
        WALK_NORTH,
        WALK_SOUTH,
        WALK_EAST,
        WALK_WEST,
        JUMP_NORTH,
        JUMP_SOUTH,
        JUMP_EAST,
        JUMP_WEST,
        LIGHTUP
    };

    public List<ProgramInstructionType> programInstructionList = new List<ProgramInstructionType>();

    public static readonly string[] instructions = new string[12];
    public void SetProgramInstructions(){
        instructions[(int)ProgramInstructionType.WALK_NORTH] = "Walk North";
        instructions[(int)ProgramInstructionType.WALK_SOUTH] = "Walk South";
        instructions[(int)ProgramInstructionType.WALK_EAST] = "Walk East";
        instructions[(int)ProgramInstructionType.WALK_WEST] = "Walk West";
        instructions[(int)ProgramInstructionType.JUMP_NORTH] = "Jump North";
        instructions[(int)ProgramInstructionType.JUMP_SOUTH] = "Jump South";
        instructions[(int)ProgramInstructionType.JUMP_EAST] = "Jump East";
        instructions[(int)ProgramInstructionType.JUMP_WEST] = "Jump West";
        instructions[(int)ProgramInstructionType.LIGHTUP] = "Light square";
    }
}

