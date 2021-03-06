﻿using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace objdump.Instructions {

    // SEC - Set Carry Flag.
    // 1001 0100 0000 1000
    public class sec: IInstruction {

        public OpInfo info;
        public OpInfo OpInfo { get { return info; } }

        public sec() { info = new OpInfo( "SEC", "Set Carry Flag",
            new Regex( @"1001010000001000", RegexOptions.Compiled ) ); }

        public string Disassemble( List< Record > list, ref int counter ) { 
        
            // Формируем ассемблерный вид команды.

            // Название инструкции.
            var op = info.Name.PadRight( Program.ArgumentsPad + Program.CommentsPad, ' ' );
                
            // Описание.
            op += info.Description;
                
            return op;
        
        }

    }

}
