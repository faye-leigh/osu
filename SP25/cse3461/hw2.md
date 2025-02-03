# Homework 2

## P1

Suppose you wanted to do a transaction from a remote client to a server as fast as
possible. Would you use UDP or TCP? Why?

#### Answer

UDP would be used because it is connectionless and has lower overhead compared to TCP. This results in faster transmission as there is no need for connection establishment, error checking, or acknowledgment.

## P2

Will Web caching reduce the delay for all objects requested by a user or for only some of
the objects? Why?

#### Answer

Web caching will reduce the delay for only some of the objects, specifically those that are stored in the cache. Objects not in the cache will still need to be fetched from the original server, which incurs the usual delay.

## P3

Suppose within your Web browser you click on a link to obtain a Web page. The IP address for the associated URL is not cached in your local host, so a DNS lookup is necessary to obtain the IP address. Suppose that n DNS servers are visited before your host receives the IP address from DNS; the successive visits incur an RTT of RTT1 , ..., RTTn . Further suppose that the Web page associated with the link contains exactly one object, consisting ofa small amount of HTML text. Let RTT0 denote the RTT between the local host and the server containing the object. Assuming zero ransmission time of the object, how much time elapses from when the client clicks on the link until the client receives the object?analog signal. How much time elapses from the time a bit is created (from the original analog signal at Host A) until the bit is decoded (as part of the analog signal at Host B)?

#### Answer:

The total time elapsed will be the sum of the RTTs for the DNS lookups and the RTT for the HTTP request and response. Therefore, the total time is RTT1 + RTT2 + ... + RTTn + RTT0.

## P4

Referring to Problem P3, suppose the HTML file references eight very small objects on the same server. Neglecting transmission times, how much time elapses with

a. Non-persistent HTTP with no parallel TCP connections?

b. Non-persistent HTTP with the browser configured for 6 parallel connections?

c. Persistent HTTP?

#### Answer:

a. Non-persistent HTTP with no parallel TCP connections:
The total time will be RTT1 + RTT2 + ... + RTTn + 9 \* RTT0 (1 RTT for the initial HTML file and 8 RTTs for the small objects).

b. Non-persistent HTTP with the browser configured for 6 parallel connections:
The total time will be RTT1 + RTT2 + ... + RTTn + 2 \* RTT0 (1 RTT for the initial HTML file and 1 RTT for the first 6 objects, plus 1 RTT for the remaining 2 objects).

c. Persistent HTTP:
The total time will be RTT1 + RTT2 + ... + RTTn + RTT0 + 8 \* (transmission time), but since transmission times are neglected, it simplifies to RTT1 + RTT2 + ... + RTTn + RTT0.

## P5

Consider a DASH system for which there are N video versions (at N different rates and
qualities) and N audio versions (at N different rates and qualities). Suppose we want to allow the player to choose at any time any of the N video versions and any of the N audio versions.
a. If we create files so that the audio is mixed in with the video, so server sends only one media stream at given time, how many files will the server need to store (each a different URL)?
b. If the server instead sends the audio and video streams separately and has the client
synchronize the streams, how many files will the server need to store?

#### Answer:

a. If we create files so that the audio is mixed in with the video, the server will need to store \( N \times N \) files. This is because for each of the N video versions, there are N corresponding audio versions, resulting in \( N \times N \) combinations.

b. If the server sends the audio and video streams separately and has the client synchronize the streams, the server will need to store \( N + N \) files. This is because there are N video files and N audio files, resulting in a total of \( N + N = 2N \) files.
