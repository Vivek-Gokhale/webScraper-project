in download button click event
Sub

dim sem as integer = cmbsem.SelectedIndex

select case sem
	case 0
	'syllabus
		If chksyl1.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3300001.pdf >> url.txt ")
            Close()
        End If
		If chksyl2.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3300002.pdf >> url.txt ")
            Close()
        End If
		If chksyl3.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3300003.pdf >> url.txt ")
            Close()
        End If
		If chksyl4.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3310701.pdf >> url.txt ")
            Close()
        End If
		If chksyl5.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3310702.pdf >> url.txt ")
            Close()
        End If
		If chksyl6.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3310703.pdf >> url.txt ")
            Close()
        End If
		
	'papers
		If chkyear1.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/w2018/DI/3300001.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/w2018/DI/3300002.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3300003.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3310701.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3310702.pdf>> url.txt ")
				Close()
			End If
            If chkpap6.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3310703.pdf>> url.txt ")
				Close()
			End If        
		End If
		
		If chkyear2.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3300001.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3300002.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3300003.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3310701.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3310702.pdf>> url.txt ")
				Close()
			End If
            If chkpap6.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3310703.pdf>> url.txt ")
				Close()
			End If        
		End If
		If chkyear3.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3300001.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3300002.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3300003.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3310701.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3310702.pdf>> url.txt ")
				Close()
			End If
            If chkpap6.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3310703.pdf>> url.txt ")
				Close()
			End If        
		End If
		If chkyear4.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3300001.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3300002.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3300003.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3310701.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3310702.pdf>> url.txt ")
				Close()
			End If
            If chkpap6.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3310703.pdf>> url.txt ")
				Close()
			End If        
		End If
		If chkyear5.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3300001.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3300002.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3300003.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3310701.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3310702.pdf>> url.txt ")
				Close()
			End If
            If chkpap6.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3310703.pdf>> url.txt ")
				Close()
			End If        
		End If
		If chkyear6.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3300001.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3300002.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3300003.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3310701.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3310702.pdf>> url.txt ")
				Close()
			End If
            If chkpap6.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3310703.pdf>> url.txt ")
				Close()
			End If        
		End If
	
	
	case 1
	'syllabus
		If chksyl1.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320002.pdf >> url.txt ")
            Close()
		End If
		If chksyl2.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320705.pdf >> url.txt ")
            Close()
		End If
		If chksyl3.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320701.pdf >> url.txt ")
            Close()
		End If
		If chksyl4.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320702.pdf >> url.txt ")
            Close()
		End If
		If chksyl5.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3320703.pdf >> url.txt ")
            Close()
		End If
		
	'PAPERS
		If chkyear1.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320002.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320705.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320701.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320702.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3320703.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		
		If chkyear2.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320002.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320705.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320701.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320702.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3320703.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear3.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320002.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320705.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320701.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320702.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3320703.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear4.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320002.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320705.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320701.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320702.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3320703.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear5.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320002.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320705.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320701.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320702.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3320703.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear6.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320002.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320705.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320701.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320702.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3320703.pdf>> url.txt ")
				Close()
			End If       
		End If
	
	'assignment
		
	case 2
	'syllabus
		If chksyl1.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330701.pdf >> url.txt ")
            Close()
		End If
		If chksyl2.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330702.pdf >> url.txt ")
            Close()
		End If
		If chksyl3.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330703.pdf >> url.txt ")
            Close()
		End If
		If chksyl4.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330704.pdf >> url.txt ")
            Close()
		End If
		If chksyl5.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3330705.pdf >> url.txt ")
            Close()
		End If
	    	
	'PAPERS
		If chkyear1.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330704.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3330705.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear2.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330704.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3330705.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear3.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330704.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3330705.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear4.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330704.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3330705.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear5.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330704.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3330705.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear6.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330704.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3330705.pdf>> url.txt ")
				Close()
			End If       
		End If
		
	case 3
	'syllabus
		If chksyl1.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340701.pdf >> url.txt ")
            Close()
		End If
	    If chksyl2.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340702.pdf >> url.txt ")
            Close()
		End If
	    If chksyl3.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3341603.pdf >> url.txt ")
            Close()
		End If
	    If chksyl4.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340705.pdf >> url.txt ")
            Close()
		End If
	    If chksyl5.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3340704.pdf >> url.txt ")
            Close()
		End If
	    
	'PAPER
		If chkyear1.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3341603.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340705.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3340704.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear2.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3341603.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340705.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3340704.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear3.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3341603.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340705.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3340704.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear4.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3341603.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340705.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3340704.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear5.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3341603.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340705.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3340704.pdf>> url.txt ")
				Close()
			End If       
		End If
		
		If chkyear6.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3341603.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340705.pdf>> url.txt ")
				Close()
			End If
            If chkpap5.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3340704.pdf>> url.txt ")
				Close()
			End If       
		End If
		
	case 4
	'syllabus
		If chksyl1.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350701.pdf >> url.txt ")
            Close()
		End If
	    If chksyl2.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350702.pdf >> url.txt ")
            Close()
		End If
	    If chksyl3.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350703.pdf >> url.txt ")
            Close()
		End If
	    If chksyl4.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3350704.pdf >> url.txt ")
            Close()
		End If
	    
	'PAPER
		If chkyear1.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3350704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear2.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3350704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear3.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3350704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear4.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3350704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear5.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3350704.pdf>> url.txt ")
				Close()
			End If
        
		If chkyear6.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3350704.pdf>> url.txt ")
				Close()
			End If
            
	case 5
	'syllabus
		If chksyl1.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360701.pdf >> url.txt ")
            Close()
		End If
	    If chksyl2.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360702.pdf >> url.txt ")
            Close()
		End If
	    If chksyl3.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360703.pdf >> url.txt ")
            Close()
		End If
	    If chksyl4.Checked = True Then
            Shell("cmd.exe /k echo https://s3-ap-southeast-1.amazonaws.com/gtusitecirculars/Syallbus/3360704.pdf >> url.txt ")
            Close()
		End If
	    
	'PAPERS
		If chkyear1.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2018/DI/3360704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear2.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2018/DI/3360704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear3.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2019/DI/3360704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear4.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2019/DI/3360704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear5.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/W2020/DI/3360704.pdf>> url.txt ")
				Close()
			End If
            
		If chkyear6.Checked = True Then
			If chkpap1.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360701.pdf>> url.txt ")
				Close()
			End If
            If chkpap2.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360702.pdf>> url.txt ")
				Close()
			End If
            If chkpap3.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360703.pdf>> url.txt ")
				Close()
			End If
            If chkpap4.Checked = True Then
				Shell("cmd.exe /k echo https://www.gtu.ac.in/uploads/S2020/DI/3360704.pdf>> url.txt ")
				Close()
			End If
            		
end Select

Shell("wget.exe --no-check-certificate -i url.txt -o D:\downloadDestination")

Close()

End Sub