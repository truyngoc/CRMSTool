using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace CRMSTestPL
{
    public class ImportDeclaration
    {
        public static void readerToToKhaiData_Declaration(OleDbDataReader dr, ref List<ToKhaiData> dlTK)
        {
            while (dr.Read())
            {
                if (dr.GetValue(0) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(0).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.SIKNO", 0, "STRING", dr.GetValue(0).ToString().Trim(), 0)); }
                if (dr.GetValue(1) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(1).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.RPEAT", 0, "STRING", dr.GetValue(1).ToString().Trim(), 0)); }
                if (dr.GetValue(2) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(2).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.SINKS", 0, "STRING", dr.GetValue(2).ToString().Trim(), 0)); }
                if (dr.GetValue(3) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(3).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.CARGO", 0, "STRING", dr.GetValue(3).ToString().Trim(), 0)); }
                if (dr.GetValue(4) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(4).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TRANS", 0, "STRING", dr.GetValue(4).ToString().Trim(), 0)); }
                if (dr.GetValue(5) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(5).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.SHIKS", 0, "STRING", dr.GetValue(5).ToString().Trim(), 0)); }
                if (dr.GetValue(6) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(6).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUNYC", 0, "STRING", dr.GetValue(6).ToString().Trim(), 0)); }
                if (dr.GetValue(7) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(7).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUNN1", 0, "STRING", dr.GetValue(7).ToString().Trim(), 0)); }
                if (dr.GetValue(8) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(8).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUNYA", 0, "STRING", dr.GetValue(8).ToString().Trim(), 0)); }
                if (dr.GetValue(9) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(9).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUNTL", 0, "STRING", dr.GetValue(9).ToString().Trim(), 0)); }
                if (dr.GetValue(10) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(10).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.CYUK1", 0, "STRING", dr.GetValue(10).ToString().Trim(), 0)); }
                if (dr.GetValue(11) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(11).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.CYUK2", 0, "STRING", dr.GetValue(11).ToString().Trim(), 0)); }
                if (dr.GetValue(12) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(12).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUSYC", 0, "STRING", dr.GetValue(12).ToString().Trim(), 0)); }
                if (dr.GetValue(13) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(13).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUNN2", 0, "STRING", dr.GetValue(13).ToString().Trim(), 0)); }
                if (dr.GetValue(14) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(14).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUSYA1", 0, "STRING", dr.GetValue(14).ToString().Trim(), 0)); }
                if (dr.GetValue(15) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(15).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUSYA2", 0, "STRING", dr.GetValue(15).ToString().Trim(), 0)); }
                if (dr.GetValue(16) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(16).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUSYA3", 0, "STRING", dr.GetValue(16).ToString().Trim(), 0)); }
                if (dr.GetValue(17) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(17).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUSYA4", 0, "STRING", dr.GetValue(17).ToString().Trim(), 0)); }
                if (dr.GetValue(18) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(18).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YUSYK", 0, "STRING", dr.GetValue(18).ToString().Trim(), 0)); }
                if (dr.GetValue(19) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(19).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.SINKY", 0, "STRING", dr.GetValue(19).ToString().Trim(), 0)); }
                if (dr.GetValue(20) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(20).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWBNB_1", 0, "STRING", dr.GetValue(20).ToString().Trim(), 0)); }
                if (dr.GetValue(21) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(21).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWBNB_2", 0, "STRING", dr.GetValue(21).ToString().Trim(), 0)); }
                if (dr.GetValue(22) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(22).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWBNB_3", 0, "STRING", dr.GetValue(22).ToString().Trim(), 0)); }
                if (dr.GetValue(23) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(23).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWBNB_4", 0, "STRING", dr.GetValue(23).ToString().Trim(), 0)); }
                if (dr.GetValue(24) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(24).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWBNB_5", 0, "STRING", dr.GetValue(24).ToString().Trim(), 0)); }
                if (dr.GetValue(25) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(25).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KOSUK", 0, "NUMERIC", dr.GetValue(25).ToString().Trim(), 0)); }
                if (dr.GetValue(26) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(26).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KOSUT", 0, "STRING", dr.GetValue(26).ToString().Trim(), 0)); }
                if (dr.GetValue(27) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(27).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.WAIGW", 0, "NUMERIC", dr.GetValue(27).ToString().Trim(), 0)); }
                if (dr.GetValue(28) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(28).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.WAIGT", 0, "STRING", dr.GetValue(28).ToString().Trim(), 0)); }
                if (dr.GetValue(29) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(29).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.ZOUTI", 0, "STRING", dr.GetValue(29).ToString().Trim(), 0)); }
                if (dr.GetValue(30) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(30).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KAMK1", 0, "STRING", dr.GetValue(30).ToString().Trim(), 0)); }
                if (dr.GetValue(31) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(31).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.SENPC", 0, "STRING", dr.GetValue(31).ToString().Trim(), 0)); }
                if (dr.GetValue(32) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(32).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TYBNA", 0, "STRING", dr.GetValue(32).ToString().Trim(), 0)); }
                if (dr.GetValue(33) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(33).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TYNEP", 0, "DATE", dr.GetValue(33).ToString().Trim(), 0)); }
                if (dr.GetValue(34) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(34).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TRORC", 0, "STRING", dr.GetValue(34).ToString().Trim(), 0)); }
                if (dr.GetValue(35) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(35).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TRORN", 0, "STRING", dr.GetValue(35).ToString().Trim(), 0)); }
                if (dr.GetValue(36) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(36).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TMDSI", 0, "STRING", dr.GetValue(36).ToString().Trim(), 0)); }
                if (dr.GetValue(37) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(37).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TMDSM", 0, "STRING", dr.GetValue(37).ToString().Trim(), 0)); }
                if (dr.GetValue(38) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(38).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYOS_1", 0, "STRING", dr.GetValue(38).ToString().Trim(), 0)); }
                if (dr.GetValue(39) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(39).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYON_1", 0, "STRING", dr.GetValue(39).ToString().Trim(), 0)); }
                if (dr.GetValue(40) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(40).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYOS_2", 0, "STRING", dr.GetValue(40).ToString().Trim(), 0)); }
                if (dr.GetValue(41) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(41).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYON_2", 0, "STRING", dr.GetValue(41).ToString().Trim(), 0)); }
                if (dr.GetValue(42) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(42).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYOS_3", 0, "STRING", dr.GetValue(42).ToString().Trim(), 0)); }
                if (dr.GetValue(43) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(43).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYON_3", 0, "STRING", dr.GetValue(43).ToString().Trim(), 0)); }
                if (dr.GetValue(44) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(44).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYOS_4", 0, "STRING", dr.GetValue(44).ToString().Trim(), 0)); }
                if (dr.GetValue(45) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(45).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYON_4", 0, "STRING", dr.GetValue(45).ToString().Trim(), 0)); }
                if (dr.GetValue(46) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(46).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYOS_5", 0, "STRING", dr.GetValue(46).ToString().Trim(), 0)); }
                if (dr.GetValue(47) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(47).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.YSYON_5", 0, "STRING", dr.GetValue(47).ToString().Trim(), 0)); }
                if (dr.GetValue(48) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(48).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.INVOB", 0, "STRING", dr.GetValue(48).ToString().Trim(), 0)); }
                if (dr.GetValue(49) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(49).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.INVNN", 0, "STRING", dr.GetValue(49).ToString().Trim(), 0)); }
                if (dr.GetValue(50) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(50).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.INVNO", 0, "STRING", dr.GetValue(50).ToString().Trim(), 0)); }
                if (dr.GetValue(51) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(51).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.INDAY", 0, "DATE", dr.GetValue(51).ToString().Trim(), 0)); }
                if (dr.GetValue(52) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(52).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.PAYCD", 0, "STRING", dr.GetValue(52).ToString().Trim(), 0)); }
                if (dr.GetValue(53) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(53).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.INVKU", 0, "STRING", dr.GetValue(53).ToString().Trim(), 0)); }
                if (dr.GetValue(54) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(54).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.INVKJ", 0, "STRING", dr.GetValue(54).ToString().Trim(), 0)); }
                if (dr.GetValue(55) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(55).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TUKA1", 0, "STRING", dr.GetValue(55).ToString().Trim(), 0)); }
                if (dr.GetValue(56) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(56).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.INVKA", 0, "MONEY", dr.GetValue(56).ToString().Trim(), 0)); }
                if (dr.GetValue(57) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(57).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.NOZGM", 0, "STRING", dr.GetValue(57).ToString().Trim(), 0)); }
                if (dr.GetValue(58) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(58).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWADP", 0, "DATE", dr.GetValue(58).ToString().Trim(), 0)); }
                if (dr.GetValue(59) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(59).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKB_1", 0, "STRING", dr.GetValue(59).ToString().Trim(), 0)); }
                if (dr.GetValue(60) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(60).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKA_1", 0, "DATE", dr.GetValue(60).ToString().Trim(), 0)); }
                if (dr.GetValue(61) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(61).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKD_1", 0, "DATE", dr.GetValue(61).ToString().Trim(), 0)); }
                if (dr.GetValue(62) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(62).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKB_2", 0, "STRING", dr.GetValue(62).ToString().Trim(), 0)); }
                if (dr.GetValue(63) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(63).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKA_2", 0, "DATE", dr.GetValue(63).ToString().Trim(), 0)); }
                if (dr.GetValue(64) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(64).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKD_2", 0, "DATE", dr.GetValue(64).ToString().Trim(), 0)); }
                if (dr.GetValue(65) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(65).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKB_3", 0, "STRING", dr.GetValue(65).ToString().Trim(), 0)); }
                if (dr.GetValue(66) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(66).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKA_3", 0, "DATE", dr.GetValue(66).ToString().Trim(), 0)); }
                if (dr.GetValue(67) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(67).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAKD_3", 0, "DATE", dr.GetValue(67).ToString().Trim(), 0)); }
                if (dr.GetValue(68) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(68).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAZC", 0, "STRING", dr.GetValue(68).ToString().Trim(), 0)); }
                if (dr.GetValue(69) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(69).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.AWAAL", 0, "DATE", dr.GetValue(69).ToString().Trim(), 0)); }
                if (dr.GetValue(70) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(70).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.SINKD", 0, "DATE", dr.GetValue(70).ToString().Trim(), 0)); }
                if (dr.GetValue(71) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(71).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.HENTD", 0, "DATE", dr.GetValue(71).ToString().Trim(), 0)); }
                if (dr.GetValue(72) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(72).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.NOZET", 0, "MONEY", dr.GetValue(72).ToString().Trim(), 0)); }
                if (dr.GetValue(73) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(73).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKECD_1", 0, "STRING", dr.GetValue(73).ToString().Trim(), 0)); }
                if (dr.GetValue(74) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(74).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKEKM_1", 0, "STRING", dr.GetValue(74).ToString().Trim(), 0)); }
                if (dr.GetValue(75) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(75).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANZ_1", 0, "MONEY", dr.GetValue(75).ToString().Trim(), 0)); }
                if (dr.GetValue(76) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(76).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANG_1", 0, "MONEY", dr.GetValue(76).ToString().Trim(), 0)); }
                if (dr.GetValue(77) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(77).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANM_1", 0, "MONEY", dr.GetValue(77).ToString().Trim(), 0)); }
                if (dr.GetValue(78) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(78).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KARAN_1", 0, "STRING", dr.GetValue(78).ToString().Trim(), 0)); }
                if (dr.GetValue(79) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(79).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TISGI_1", 0, "INTEGER", dr.GetValue(79).ToString().Trim(), 0)); }
                if (dr.GetValue(80) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(80).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKECD_2", 0, "STRING", dr.GetValue(80).ToString().Trim(), 0)); }
                if (dr.GetValue(81) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(81).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKEKM_2", 0, "STRING", dr.GetValue(81).ToString().Trim(), 0)); }
                if (dr.GetValue(82) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(82).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANZ_2", 0, "MONEY", dr.GetValue(82).ToString().Trim(), 0)); }
                if (dr.GetValue(83) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(83).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANG_2", 0, "MONEY", dr.GetValue(83).ToString().Trim(), 0)); }
                if (dr.GetValue(84) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(84).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANM_2", 0, "MONEY", dr.GetValue(84).ToString().Trim(), 0)); }
                if (dr.GetValue(85) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(85).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KARAN_2", 0, "STRING", dr.GetValue(85).ToString().Trim(), 0)); }
                if (dr.GetValue(86) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(86).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TISGI_2", 0, "INTEGER", dr.GetValue(86).ToString().Trim(), 0)); }
                if (dr.GetValue(87) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(87).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKECD_3", 0, "STRING", dr.GetValue(87).ToString().Trim(), 0)); }
                if (dr.GetValue(88) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(88).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKEKM_3", 0, "STRING", dr.GetValue(88).ToString().Trim(), 0)); }
                if (dr.GetValue(89) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(89).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANZ_3", 0, "MONEY", dr.GetValue(89).ToString().Trim(), 0)); }
                if (dr.GetValue(90) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(90).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANG_3", 0, "MONEY", dr.GetValue(90).ToString().Trim(), 0)); }
                if (dr.GetValue(91) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(91).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANM_3", 0, "MONEY", dr.GetValue(91).ToString().Trim(), 0)); }
                if (dr.GetValue(92) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(92).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KARAN_3", 0, "STRING", dr.GetValue(92).ToString().Trim(), 0)); }
                if (dr.GetValue(93) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(93).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TISGI_3", 0, "INTEGER", dr.GetValue(93).ToString().Trim(), 0)); }
                if (dr.GetValue(94) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(94).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKECD_4", 0, "STRING", dr.GetValue(94).ToString().Trim(), 0)); }
                if (dr.GetValue(95) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(95).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKEKM_4", 0, "STRING", dr.GetValue(95).ToString().Trim(), 0)); }
                if (dr.GetValue(96) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(96).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANZ_4", 0, "MONEY", dr.GetValue(96).ToString().Trim(), 0)); }
                if (dr.GetValue(97) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(97).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANG_4", 0, "MONEY", dr.GetValue(97).ToString().Trim(), 0)); }
                if (dr.GetValue(98) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(98).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANM_4", 0, "MONEY", dr.GetValue(98).ToString().Trim(), 0)); }
                if (dr.GetValue(99) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(99).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KARAN_4", 0, "STRING", dr.GetValue(99).ToString().Trim(), 0)); }
                if (dr.GetValue(100) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(100).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TISGI_4", 0, "INTEGER", dr.GetValue(100).ToString().Trim(), 0)); }
                if (dr.GetValue(101) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(101).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKECD_5", 0, "STRING", dr.GetValue(101).ToString().Trim(), 0)); }
                if (dr.GetValue(102) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(102).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UKEKM_5", 0, "STRING", dr.GetValue(102).ToString().Trim(), 0)); }
                if (dr.GetValue(103) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(103).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANZ_5", 0, "MONEY", dr.GetValue(103).ToString().Trim(), 0)); }
                if (dr.GetValue(104) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(104).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANG_5", 0, "MONEY", dr.GetValue(104).ToString().Trim(), 0)); }
                if (dr.GetValue(105) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(105).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TKANM_5", 0, "MONEY", dr.GetValue(105).ToString().Trim(), 0)); }
                if (dr.GetValue(106) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(106).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.KARAN_5", 0, "STRING", dr.GetValue(106).ToString().Trim(), 0)); }
                if (dr.GetValue(107) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(107).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.TISGI_5", 0, "INTEGER", dr.GetValue(107).ToString().Trim(), 0)); }
                if (dr.GetValue(108) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(108).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.ATZEI", 0, "STRING", dr.GetValue(108).ToString().Trim(), 0)); }
                if (dr.GetValue(109) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(109).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.ZEIBN", 0, "STRING", dr.GetValue(109).ToString().Trim(), 0)); }
                if (dr.GetValue(110) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(110).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.UWMEI", 0, "STRING", dr.GetValue(110).ToString().Trim(), 0)); }
                if (dr.GetValue(111) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(111).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.DAIRN", 0, "STRING", dr.GetValue(111).ToString().Trim(), 0)); }
                if (dr.GetValue(112) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(112).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.HKANZ", 0, "MONEY", dr.GetValue(112).ToString().Trim(), 0)); }
                if (dr.GetValue(113) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(113).ToString())) { dlTK.Add(new ToKhaiData("TOKHAI.HOSKB", 0, "STRING", dr.GetValue(113).ToString().Trim(), 0)); }

            }
        }

        public static void readerToToKhaiData_Goods(OleDbDataReader dr, ref List<ToKhaiData> dlTK)
        {
            int i = 1;
            while (dr.Read())
            {
                if (dr.GetValue(0) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(0).ToString())) { dlTK.Add(new ToKhaiData("HANG.SIKNO", i, "STRING", dr.GetValue(0).ToString().Trim(), 1)); }
                if (dr.GetValue(1) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(1).ToString())) { dlTK.Add(new ToKhaiData("HANG.RANNB", i, "STRING", dr.GetValue(1).ToString().Trim(), 1)); }
                if (dr.GetValue(2) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(2).ToString())) { dlTK.Add(new ToKhaiData("HANG.HINMC", i, "STRING", dr.GetValue(2).ToString().Trim(), 1)); }
                if (dr.GetValue(3) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(3).ToString())) { dlTK.Add(new ToKhaiData("HANG.HINME", i, "STRING", dr.GetValue(3).ToString().Trim(), 1)); }
                if (dr.GetValue(4) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(4).ToString())) { dlTK.Add(new ToKhaiData("HANG.ORGLC", i, "STRING", dr.GetValue(4).ToString().Trim(), 1)); }
                if (dr.GetValue(5) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(5).ToString())) { dlTK.Add(new ToKhaiData("HANG.ORGNK", i, "STRING", dr.GetValue(5).ToString().Trim(), 1)); }
                if (dr.GetValue(6) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(6).ToString())) { dlTK.Add(new ToKhaiData("HANG.SURY1", i, "NUMERIC", dr.GetValue(6).ToString().Trim(), 1)); }
                if (dr.GetValue(7) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(7).ToString())) { dlTK.Add(new ToKhaiData("HANG.TANI1", i, "STRING", dr.GetValue(7).ToString().Trim(), 1)); }
                if (dr.GetValue(8) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(8).ToString())) { dlTK.Add(new ToKhaiData("HANG.SURY2", i, "NUMERIC", dr.GetValue(8).ToString().Trim(), 1)); }
                if (dr.GetValue(9) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(9).ToString())) { dlTK.Add(new ToKhaiData("HANG.TANI2", i, "STRING", dr.GetValue(9).ToString().Trim(), 1)); }
                if (dr.GetValue(10) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(10).ToString())) { dlTK.Add(new ToKhaiData("HANG.BPRIC", i, "MONEY", dr.GetValue(10).ToString().Trim(), 1)); }
                if (dr.GetValue(11) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(11).ToString())) { dlTK.Add(new ToKhaiData("HANG.TANKA", i, "MONEY", dr.GetValue(11).ToString().Trim(), 1)); }
                if (dr.GetValue(12) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(12).ToString())) { dlTK.Add(new ToKhaiData("HANG.TCODE", i, "STRING", dr.GetValue(12).ToString().Trim(), 1)); }
                if (dr.GetValue(13) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(13).ToString())) { dlTK.Add(new ToKhaiData("HANG.TTANI", i, "STRING", dr.GetValue(13).ToString().Trim(), 1)); }
                if (dr.GetValue(14) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(14).ToString())) { dlTK.Add(new ToKhaiData("HANG.FOBCD", i, "STRING", dr.GetValue(14).ToString().Trim(), 1)); }
                if (dr.GetValue(15) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(15).ToString())) { dlTK.Add(new ToKhaiData("HANG.KAZEI", i, "MONEY", dr.GetValue(15).ToString().Trim(), 1)); }
                if (dr.GetValue(16) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(16).ToString())) { dlTK.Add(new ToKhaiData("HANG.GMENF", i, "STRING", dr.GetValue(16).ToString().Trim(), 1)); }
                if (dr.GetValue(17) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(17).ToString())) { dlTK.Add(new ToKhaiData("HANG.GMEZG", i, "MONEY", dr.GetValue(17).ToString().Trim(), 1)); }
                if (dr.GetValue(18) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(18).ToString())) { dlTK.Add(new ToKhaiData("HANG.KAZTK", i, "MONEY", dr.GetValue(18).ToString().Trim(), 1)); }
                if (dr.GetValue(19) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(19).ToString())) { dlTK.Add(new ToKhaiData("HANG.KAZTN", i, "STRING", dr.GetValue(19).ToString().Trim(), 1)); }
                if (dr.GetValue(20) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(20).ToString())) { dlTK.Add(new ToKhaiData("HANG.ZEIIN", i, "STRING", dr.GetValue(20).ToString().Trim(), 1)); }
                if (dr.GetValue(21) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(21).ToString())) { dlTK.Add(new ToKhaiData("HANG.KANKS", i, "NUMERIC", dr.GetValue(21).ToString().Trim(), 1)); }
                if (dr.GetValue(22) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(22).ToString())) { dlTK.Add(new ToKhaiData("HANG.KANKT", i, "STRING", dr.GetValue(22).ToString().Trim(), 1)); }
                if (dr.GetValue(23) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(23).ToString())) { dlTK.Add(new ToKhaiData("HANG.KANKG", i, "MONEY", dr.GetValue(23).ToString().Trim(), 1)); }
                if (dr.GetValue(24) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(24).ToString())) { dlTK.Add(new ToKhaiData("HANG.KANRT", i, "NUMERIC", dr.GetValue(24).ToString().Trim(), 1)); }
                if (dr.GetValue(25) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(25).ToString())) { dlTK.Add(new ToKhaiData("HANG.KANTU", i, "STRING", dr.GetValue(25).ToString().Trim(), 1)); }
                if (dr.GetValue(26) != DBNull.Value && !string.IsNullOrWhiteSpace(dr.GetValue(26).ToString())) { dlTK.Add(new ToKhaiData("HANG.LOWSY", i, "STRING", dr.GetValue(26).ToString().Trim(), 1)); }

                i += 1;
            }
        }
    }
}
