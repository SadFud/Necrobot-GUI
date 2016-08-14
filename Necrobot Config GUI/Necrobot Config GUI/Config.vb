Imports System
Imports System.IO

Public Class Config
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox(comboidioma.Text)
        Dim path2 As String = Directory.GetCurrentDirectory()
        Dim fic2 As String = path2 & "\config\" & "configtemp.txt"
        Dim ficfinal2 As String = path2 & "\config\" & "config.json"
        Dim idioma As String = comboidioma.Text
        Dim actualizar As String
        Dim verdad As String = "true"
        Dim mentira As String = "false"
        Dim websocket As String
        Dim pokemonstart As String = displaytrack.Value
        Dim ballshow As String
        Dim lvlup As String
        Dim stardust As String = stardustnum.Value
        Dim lvluptipo As String
        Dim humanwalk As String
        Dim dump As String
        Dim evolveiv As String = evivnum.Value
        Dim eviv As String
        Dim evcandy As String
        Dim keepev As String
        Dim keepminlvl As String
        Dim priorize As String
        Dim eggck As String
        Dim luckyegg As String
        Dim luckyev As String
        Dim incense As String
        Dim local As String = "localhost"
        Dim snipeport As String = "16969"
        Dim lanzarhumano As String
        Dim transferweak As String
        Dim transferdup As String
        Dim transferdupcap As String
        'si el archivo config existe lo borra antes de nada
        If File.Exists(ficfinal2) Then
            File.Delete(ficfinal2)
        End If

        '############## SECCION GENERAL

        'chequea la auto update
        If updatecheck.Checked = True Then
            actualizar = "true"
        Else
            actualizar = "false"
        End If
        'check web socket
        If websocketcheck.Checked = True Then
            websocket = verdad
        Else
            websocket = mentira
        End If
        'check pokeballs recycle at start
        If pokeshowcheck.Checked = True Then
            ballshow = verdad
        Else
            ballshow = mentira
        End If

        '#############                SECCION UPGRADING

        ' lvl up automatico
        If lvlupcheck.Checked = True Then
            lvlup = verdad
        Else
            lvlup = mentira
        End If
        'tipo de evolucion Cp o IV
        If radiocp.Checked = True Then
            lvluptipo = "cp"
        Else
            lvluptipo = "iv"
        End If

        '############ SECCION LOCATION

        If humancheck.Checked = True Then
            humanwalk = mentira
        Else
            humanwalk = verdad
        End If
        If dumpcheck.Checked = True Then
            dump = verdad
        Else
            dump = mentira
        End If

        '############## SECCION EVOLUCION

        If evivcheck.Checked = True Then
            eviv = verdad
        Else
            eviv = mentira

        End If
        'evolucion con caramelitos
        If evcandycheck.Checked = True Then
            evcandy = verdad
        Else
            evcandy = mentira

        End If
        'mantener pokemons 
        If keepevcheck.Checked = True Then
            keepev = verdad
        Else
            keepev = mentira
        End If
        'UseKeepMinLvl
        If minlvlcheck.Checked = True Then
            keepminlvl = verdad
        Else
            keepminlvl = mentira
        End If
        If priorizecheck.Checked = True Then
            priorize = verdad
        Else
            priorize = mentira
        End If

        '##############################     SECION INVENTARIO
        'incubar huevos
        If eggcheck.Checked = True Then
            eggck = verdad
        Else
            eggck = mentira
        End If
        'incubar huevos de la suerte
        If luckyeggcheck.Checked = True Then
            luckyegg = verdad
        Else
            luckyegg = mentira
        End If
        If luckyevcheck.Checked = True Then
            luckyev = verdad
        Else
            luckyev = mentira
        End If
        If incensecheck.Checked = True Then
            incense = verdad
        Else
            incense = mentira
        End If

        '########################## SECCION CAPTURAR

        If humanthrowscheck.Checked = True Then
            lanzarhumano = verdad
        Else
            lanzarhumano = mentira
        End If

        '###########################     SECCION TRANSFER

        If transferweakcheck.Checked = True Then
            transferweak = verdad
        Else
            transferweak = mentira
        End If

        If transferdupcheck.Checked = True Then
            transferdup = verdad
        Else
            transferdup = mentira
        End If

        If tradupcapcheck.Checked = True Then
            transferdupcap = verdad
        Else
            transferdupcap = mentira
        End If
        '##########################empieza la escritura del archivo


        Dim sw As New System.IO.StreamWriter(fic2, True)
        sw.WriteLine("{")
        sw.WriteLine("  ""TranslationLanguageCode""" & ": " & """" & idioma & """" & ",")
        sw.WriteLine("  ""AutoUpdate""" & ": " & actualizar & ",")
        sw.WriteLine("  ""TransferConfigAndAuthOnUpdate""" & ": " & mentira & ",")
        sw.WriteLine("  ""UseWebsocket""" & ": " & websocket & ",")
        sw.WriteLine("  ""StartupWelcomeDelay""" & ": " & mentira & ",")
        'sw.WriteLine("  ""UseTelegramAPI""" & ": " & mentira & ",")
        'sw.WriteLine("  ""TelegramAPIKey""" & ": " & "null" & ",")
        sw.WriteLine("  ""AmountOfPokemonToDisplayOnStart""" & ": " & pokemonstart & ",")
        sw.WriteLine("  ""ShowPokeballCountsBeforeRecycle""" & ": " & ballshow & ",")
        sw.WriteLine("  ""CatchPokemon""" & ": " & verdad & ",")
        sw.WriteLine("  ""AutomaticallyLevelUpPokemon""" & ": " & lvlup & ",")
        sw.WriteLine("  ""AmountOfTimesToUpgradeLoop""" & ": " & "5" & ",")
        sw.WriteLine("  ""GetMinStarDustForLevelUp""" & ": " & stardust & ",")
        sw.WriteLine("  ""LevelUpByCPorIv""" & ": " & """" & lvluptipo & """" & ",")
        sw.WriteLine("  ""UpgradePokemonCpMinimum""" & ": " & cpnum.Value & ",")
        sw.WriteLine("  ""UpgradePokemonIvMinimum""" & ": " & ivnum.Value & ",")
        sw.WriteLine("  ""UpgradePokemonMinimumStatsOperator""" & ": " & """" & "and" & """" & ",")
        sw.WriteLine("  ""DisableHumanWalking""" & ": " & humanwalk & ",")
        sw.WriteLine("  ""DefaultLatitude""" & ": " & latitext.Text & ",")
        sw.WriteLine("  ""DefaultLongitude""" & ": " & longitext.Text & ",")
        sw.WriteLine("  ""WalkingSpeedInKilometerPerHour""" & ": " & velocidadnum.Value & ",")
        sw.WriteLine("  ""MaxSpawnLocationOffset""" & ": " & "10" & ",")
        sw.WriteLine("  ""DelayBetweenPlayerActions""" & ": " & "5000" & ",")
        sw.WriteLine("  ""DelayBetweenPokemonCatch""" & ": " & "2000" & ",")
        sw.WriteLine("  ""DumpPokemonStats""" & ": " & dump & ",")
        sw.WriteLine("  ""EvolveAboveIvValue""" & ": " & evolveiv & ",")
        sw.WriteLine("  ""EvolveAllPokemonAboveIv""" & ": " & eviv & ",")
        sw.WriteLine("  ""EvolveAllPokemonWithEnoughCandy""" & ": " & evcandy & ",")
        sw.WriteLine("  ""EvolveKeptPokemonsAtStorageUsagePercentage""" & ": " & "90.0" & ",")
        sw.WriteLine("  ""KeepPokemonsThatCanEvolve""" & ": " & keepev & ",")
        sw.WriteLine("  ""KeepMinCp""" & ": " & mincpnum.Value & ",")
        sw.WriteLine("  ""KeepMinIvPercentage""" & ": " & keepminnum.Value & ",")
        sw.WriteLine("  ""KeepMinLvl""" & ": " & minlvlkeepnum.Value & ",")
        sw.WriteLine("  ""KeepMinOperator""" & ": " & """" & "or" & """" & ",")
        sw.WriteLine("  ""UseKeepMinLvl""" & ": " & keepminlvl & ",")
        sw.WriteLine("  ""PrioritizeIvOverCp""" & ": " & priorize & ",")
        sw.WriteLine("  ""KeepMinDuplicatePokemon""" & ": " & duplicatenum.Value & ",")
        sw.WriteLine("  ""UseGpxPathing""" & ": " & mentira & ",")
        sw.WriteLine("  ""GpxFile""" & ": " & """" & "GPXPath.GPX" & """" & ",")
        sw.WriteLine("  ""VerboseRecycling""" & ": " & verdad & ",")
        sw.WriteLine("  ""RecycleInventoryAtUsagePercentage""" & ": " & "90.0" & ",")
        sw.WriteLine("  ""UseEggIncubators""" & ": " & eggck & ",")
        sw.WriteLine("  ""UseLuckyEggConstantly""" & ": " & evolveiv & ",")
        sw.WriteLine("  ""UseLuckyEggsMinPokemonAmount""" & ": " & luckyeggnum.Value & ",")
        sw.WriteLine("  ""UseLuckyEggsWhileEvolving""" & ": " & luckyev & ",")
        sw.WriteLine("  ""UseIncenseConstantly""" & ": " & incense & ",")
        sw.WriteLine("  ""UseBerriesMinCp""" & ": " & berriesnum.Value & ",")
        sw.WriteLine("  ""UseBerriesMinIv""" & ": " & berriesivnum.Value & ",")
        sw.WriteLine("  ""UseBerriesBelowCatchProbability""" & ": " & "0.2" & ",")
        sw.WriteLine("  ""UseBerriesOperator""" & ": " & """" & "and" & """" & ",")
        sw.WriteLine("  ""UseSnipeOnlineLocationServer""" & ": " & verdad & ",")
        sw.WriteLine("  ""UseSnipeLocationServer""" & ": " & mentira & ",")
        sw.WriteLine("  ""SnipeLocationServer""" & ": " & """" & local & """" & ",")
        sw.WriteLine("  ""SnipeLocationServerPort""" & ": " & snipeport & ",")
        sw.WriteLine("  ""GetSniperInfoFromPokezz""" & ": " & verdad & ",")
        sw.WriteLine("  ""GetOnlyVerifiedSniperInfoFromPokezz""" & ": " & verdad & ",")
        sw.WriteLine("  ""MinPokeballsToSnipe""" & ": " & "20" & ",")
        sw.WriteLine("  ""MinPokeballsWhileSnipe""" & ": " & "0" & ",")
        sw.WriteLine("  ""MinDelayBetweenSnipes""" & ": " & "60000" & ",")
        sw.WriteLine("  ""SnipingScanOffset""" & ": " & "0.003" & ",")
        sw.WriteLine("  ""SnipeAtPokestops""" & ": " & mentira & ",")
        sw.WriteLine("  ""SnipeIgnoreUnknownIv""" & ": " & mentira & ",")
        sw.WriteLine("  ""UseTransferIvForSnipe""" & ": " & mentira & ",")
        sw.WriteLine("  ""SnipePokemonNotInPokedex""" & ": " & mentira & ",")
        sw.WriteLine("  ""RenamePokemon""" & ": " & mentira & ",")
        sw.WriteLine("  ""RenameOnlyAboveIv""" & ": " & verdad & ",")
        sw.WriteLine("  ""RenameTemplate""" & ": " & """" & "{1}_{0}" & """" & ",")
        sw.WriteLine("  ""MaxPokeballsPerPokemon""" & ": " & maxballsnum.Value & ",")
        sw.WriteLine("  ""MaxTravelDistanceInMeters""" & ": " & travelnum.Value & ",")
        sw.WriteLine("  ""TotalAmountOfPokeballsToKeep""" & ": " & totalballsnum.Value & ",")
        sw.WriteLine("  ""TotalAmountOfPotionsToKeep""" & ": " & maxpotionsnum.Value & ",")
        sw.WriteLine("  ""TotalAmountOfRevivesToKeep""" & ": " & maxrevivesnum.Value & ",")
        sw.WriteLine("  ""TotalAmountOfBerriesToKeep""" & ": " & maxberriesnum.Value & ",")
        sw.WriteLine("  ""UseGreatBallAboveCp""" & ": " & gbnum.Value & ",")
        sw.WriteLine("  ""UseUltraBallAboveCp""" & ": " & ubnum.value & ",")
        sw.WriteLine("  ""UseMasterBallAboveCp""" & ": " & mbnum.value & ",")
        sw.WriteLine("  ""UseGreatBallAboveIv""" & ": " & gbivnum.value & ",")
        sw.WriteLine("  ""UseUltraBallAboveIv""" & ": " & ubivnum.Value & ",")
        sw.WriteLine("  ""UseGreatBallBelowCatchProbability""" & ": " & "0.2" & ",") 'gbprobnum.value
        sw.WriteLine("  ""UseUltraBallBelowCatchProbability""" & ": " & "0.1" & ",") 'ubprobnum.value
        sw.WriteLine("  ""UseMasterBallBelowCatchProbability""" & ": " & "0.01" & ",") 'mbprobnum.Value
        sw.WriteLine("  ""EnableHumanizedThrows""" & ": " & lanzarhumano & ",")
        sw.WriteLine("  ""NiceThrowChance""" & ": " & "40" & ",") 'asdads
        sw.WriteLine("  ""GreatThrowChance""" & ": " & "30" & ",") 'dasdas
        sw.WriteLine("  ""ExcellentThrowChance""" & ": " & "10" & ",") ' adsdas
        sw.WriteLine("  ""CurveThrowChance""" & ": " & "90" & ",") ' adsdasdas
        sw.WriteLine("  ""ForceGreatThrowOverIv""" & ": " & "90.0" & ",") ' adsdasdas
        sw.WriteLine("  ""ForceExcellentThrowOverIv""" & ": " & "95.0" & ",") 'adsdasdas
        sw.WriteLine("  ""ForceGreatThrowOverCp""" & ": " & "1000" & ",") ' asddasads
        sw.WriteLine("  ""ForceExcellentThrowOverCp""" & ": " & "1500" & ",") 'asddasdsads
        sw.WriteLine("  ""TransferWeakPokemon""" & ": " & transferweak & ",")
        sw.WriteLine("  ""TransferDuplicatePokemon""" & ": " & transferdup & ",")
        sw.WriteLine("  ""TransferDuplicatePokemonOnCapture""" & ": " & transferdupcap & ",")
        sw.WriteLine("  ""FavoriteMinIvPercentage""" & ": " & "95.0" & ",")
        sw.WriteLine("  ""AutoFavoritePokemon""" & ": " & mentira & ",")
        sw.WriteLine("  ""UsePokemonToNotCatchFilter""" & ": " & mentira & ",")
        sw.WriteLine("  ""UsePokemonSniperFilterOnly""" & ": " & mentira & ",")
        sw.WriteLine("  ""WebSocketPort""" & ": " & "14251" & ",")
        'sw.WriteLine("  ""CatchPokemon""" & ": " & evolveiv & ",")
        sw.Close()
        Rename(fic2, ficfinal2)
        MsgBox("Config.json generated in " & ficfinal2 & ".")
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Clipboard.SetText(TextBox1.Text)
        MsgBox("Auxiliary code copied to the clipboard.")
    End Sub

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbprobnum.Enabled = False
        ubprobnum.Enabled = False
        mbprobnum.Enabled = False

    End Sub
End Class