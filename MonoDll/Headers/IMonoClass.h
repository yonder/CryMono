/////////////////////////////////////////////////////////////////////////*
//Ink Studios Source File.
//Copyright (C), Ink Studios, 2011.
//////////////////////////////////////////////////////////////////////////
// IMonoClass interface for external projects, i.e. CryGame.
//////////////////////////////////////////////////////////////////////////
// 18/12/2011 : Created by Filip 'i59' Lundgren
////////////////////////////////////////////////////////////////////////*/
#ifndef __I_MONO_CLASS__
#define __I_MONO_CLASS__

struct IMonoObject;
struct IMonoArray;

struct IMonoClass
{
public:
	virtual IMonoObject *CallMethod(const char *methodName, IMonoArray *params = NULL, bool _static = false) = 0;
};

#endif //__I_MONO_CLASS__