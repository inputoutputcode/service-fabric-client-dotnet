# New-SFApplication
Creates a Service Fabric application.
## Description

Creates a Service Fabric application using the specified description.



## Required Parameters
#### -Name

The name of the application, including the 'fabric:' URI scheme.



#### -TypeName

The application type name as defined in the application manifest.



#### -TypeVersion

The version of the application type as defined in the application manifest.



## Optional Parameters
#### -Parameters

List of application parameters with overridden values from their default values specified in the application manifest.



#### -MinimumNodes

The minimum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not 
mean that the services of this application will be placed on all of those nodes. If this property is set to zero, no 
capacity will be reserved. The value of this property cannot be more than the value of the MaximumNodes property.



#### -MaximumNodes

The maximum number of nodes where Service Fabric will reserve capacity for this application. Note that this does not 
mean that the services of this application will be placed on all of those nodes. By default, the value of this 
property is zero and it means that the services can be placed on any node.



#### -ApplicationMetrics

List of application capacity metric description.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



