# Update-SFService
Updates a Service Fabric service using the specified update description.
## Description

This API allows updating properties of a running Service Fabric service. The set of properties that can be updated are 
a subset of the properties that were specified at the time of creating the service. The current set of properties can 
be obtained using `GetServiceDescription` API. Note that updating the properties of a running service is different 
than upgrading your application using `StartApplicationUpgrade` API. The upgrade is a long running background 
operation that involves moving the application from one version to another, one upgrade domain at a time, whereas 
update applies the new properties immediately to the service.



## Optional Parameters
#### -Flags

Flags indicating whether other properties are set. Each of the associated properties corresponds to a flag, specified 
below, which, if set, indicate that the property is specified.
                    This property can be a combination of those flags obtained using bitwise 'OR' operator.
                    For example, if the provided value is 6 then the flags for ReplicaRestartWaitDuration (2) and 
QuorumLossWaitDuration (4) are set.
                    
                    - None - Does not indicate any other properties are set. The value is zero.
                    - TargetReplicaSetSize/InstanceCount - Indicates whether the TargetReplicaSetSize property (for 
Stateful services) or the InstanceCount property (for Stateless services) is set. The value is 1.
                    - ReplicaRestartWaitDuration - Indicates the ReplicaRestartWaitDuration property is set. The value 
is  2.
                    - QuorumLossWaitDuration - Indicates the QuorumLossWaitDuration property is set. The value is 4.
                    - StandByReplicaKeepDuration - Indicates the StandByReplicaKeepDuration property is set. The value 
is 8.
                    - MinReplicaSetSize - Indicates the MinReplicaSetSize property is set. The value is 16.
                    - PlacementConstraints - Indicates the PlacementConstraints property is set. The value is 32.
                    - PlacementPolicyList - Indicates the ServicePlacementPolicies property is set. The value is 64.
                    - Correlation - Indicates the CorrelationScheme property is set. The value is 128.
                    - Metrics - Indicates the ServiceLoadMetrics property is set. The value is 256.
                    - DefaultMoveCost - Indicates the DefaultMoveCost property is set. The value is 512.
                    - ScalingPolicy - Indicates the ScalingPolicies property is set. The value is 1024.



#### -PlacementConstraints

The placement constraints as a string. Placement constraints are boolean expressions on node properties and allow for 
restricting a service to particular nodes based on the service requirements. For example, to place a service on nodes 
where NodeType is blue specify the following: "NodeColor == blue)".



#### -CorrelationScheme

The correlation scheme.



#### -LoadMetrics

The service load metrics.



#### -ServicePlacementPolicies

The service placement policies.



#### -DefaultMoveCost

The move cost for the service. Possible values include: 'Zero', 'Low', 'Medium', 'High'
                    
                    Specifies the move cost for the service.



#### -ScalingPolicies

Scaling policies for this service.



#### -TargetReplicaSetSize

The target replica set size as a number.



#### -MinReplicaSetSize

The minimum replica set size as a number.



#### -ReplicaRestartWaitDurationSeconds

The duration, in seconds, between when a replica goes down and when a new replica is created.



#### -QuorumLossWaitDurationSeconds

The maximum duration, in seconds, for which a partition is allowed to be in a state of quorum loss.



#### -StandByReplicaKeepDurationSeconds

The definition on how long StandBy replicas should be maintained before being removed.



#### -InstanceCount

The instance count.



#### -ServerTimeout

The server timeout for performing the operation in seconds. This timeout specifies the time duration that the client 
is willing to wait for the requested operation to complete. The default value for this parameter is 60 seconds.



