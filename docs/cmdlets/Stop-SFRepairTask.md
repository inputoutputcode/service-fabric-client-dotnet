# Stop-SFRepairTask
Requests the cancellation of the given repair task.
## Description

This API supports the Service Fabric platform; it is not meant to be used directly from your code.



## Optional Parameters
#### -Version

The current version number of the repair task. If non-zero, then the request will only succeed if this value matches 
the actual current version of the repair task. If zero, then no version check is performed.



#### -RequestAbort

_True_ if the repair should be stopped as soon as possible even if it has already started executing. _False_ if the 
repair should be cancelled only if execution has not yet started.



