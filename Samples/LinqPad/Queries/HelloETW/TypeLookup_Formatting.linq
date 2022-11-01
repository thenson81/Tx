playback.KnownTypes = typeof(MessageLogInfo).Assembly.GetTypes();

var fmt = from e in playback.GetObservable<SystemEvent>()
select new
{
	e.Header.Timestamp,
	e.Header.RelatedActivityId,
	EventType = e.GetType().Name,
	Message = e.ToString()
};

fmt.Dump();