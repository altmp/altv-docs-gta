# Joaat

Jooat stands for "Jenkis one at a time" and is an hashing algorithm, that is used by GTA V to hash names to uint32 values. You can't get the model name from a hashed value, that's only possible by brute forcing the values.

The hash is not case sensitive and is already implemented into alt:V API, you can use alt.hash() on server and client side.

> [!TIP]
> See <a href='https://forge.plebmasters.de/joaatresolver/'>Pleb Masters: Forge</a> JOAAT Tool for a reverse JOAAT hash lookup.

## Joaat Calculator

Here you can enter a name to get the hash of it as uint32 and hex.
</br>

<input id="name" type="text" />

</br>

<div>
    <button id='generate' onclick='calcJoaat()'>Calculate Joaat</button>
</div>

<p>
    <b>name:</b></br><span id="input"></span>
</p>
<p>
    <b>uint32:</b></br><span id="uint"></span>
</p>
<p>
    <b>int32:</b></br><span id="int"></span>
</p>
<p>
    <b>hex:</b></br><span id="hex"></span>
</p>

<script>
    function calcJoaat()
    {
        let s = document.getElementById("name").value.toUpperCase();
        let n = joaat(s);
        let h = toHex(n);

        document.getElementById("input").innerHTML = s;
        document.getElementById("uint").innerHTML = ToUint32(n);
        document.getElementById("int").innerHTML = ToInt32(n);
        document.getElementById("hex").innerHTML = h;
    }
</script>