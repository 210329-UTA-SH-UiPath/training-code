
# Document Object Model

## DOM Structure

When writing web pages and apps, we manipulate the document structure using the DOM.

The DOM is a set of APIs for controlling HTML and styling information.

The DOM utilizes the Document object to manage HTML and styling information.

The document in each browser is represented by a document object model.

DOM uses the:

-   The Window object - browser tab that web page is loaded into. Always top of hierarchy
    
-   Navigator object represents state and identity of browser
    
-   Document object - actual page loaded into window
    

- Document Object Methods:

	-   write(“text”)
    
	-   getElementById()
    
	-   getElementByName();
    
	-   getElementsByTagName()
    
	-   getElementsByClassName()
    

-   Constructed as a tree of Objects. This allows the structure to be easily accessed, stylized, and manipulated (eg, Javascript and CSS).
    
-   Text and elements within the document are called nodes
    

	-   Element node
    
	-   Root node: Top of hierarchy (eg, HTML node)
    
	-   Child node: A node within another
    
	-   Descendant node: A node anywhere within another
    
	-   Parent node: A node that has at least one child node
    
	-   Sibling nodes: Nodes that are on the same level of DOM tree
    
	-   Text node: A node string
    

-   ![](https://lh6.googleusercontent.com/ll-Pf5TaGxkJsSw_HgQ9RV4RwN45r4bzI7illNgvR1X-lJZh1uo1PHd9UvZRz1_C_ieIL_fyvrEVWjjJAnNikKsh-RYZzH43s593E2l6vqaSUhYuFCaQTnc5xAmdxxaCgM3rlhIg)
    

  
  

# Selectors
To manipulate elements in DOM we need to select it and store a reference to it in a variable.
There are several ways to select an element and store it in a variable.
    
-   Document.querySelector() - modern approach and is convenient because it allows you to select elements using CSS selectors like "#id", ".class", "p.intro"
	-   Returns first element or null
    
	- https://www.w3schools.com/cssref/css_selectors.asp  
	-   Example:
    
-   ![](https://lh4.googleusercontent.com/HHlbZxVCpaWn9Jvokazw0lIjXYDEyFJeX3JG9-DDtUIZwhZxVo7iD6XaaRJ9tGZleQiiJmxISJ4o3DWNKG5ZZUvqqplL0B3SGQ-t7nMfvQOe5_DeOYzUokF_f9-RnUbaGVLdesku)
    

-   ![](https://lh4.googleusercontent.com/G8ljv30SuWGFsVwHwMOr3t5dPUlduH6Rm-wWZ2nRHX-E5vn7P4FuL4xnqyIcNoUiXH18Jg33wFleINJGaUlGOv7RMT45heqePzNLVWG4HhdF-w2Ewdwsm35DhxJb0vRr22z2SxxU)
    
-   ![](https://lh4.googleusercontent.com/QgJt-9oA1nXgC2-xDCU-TEzd7ashq1RuXuwW_a3x__BG5wZTV_Tsu49kGucZFzH-5cxaTx9DUo6Erc7kPo0OAAIVVOupZZyM1dY3vyxZlWnfhJzY9clNg5M37YuKyfG-LPYN0Iqe)
    
-   ![](https://lh5.googleusercontent.com/g_inr9UqyHT9dXL9-vwlzokWde3PJriVJjpJe35m6odMqxPqFHOnOTOCt8GpjynxSSX_OOB7-dNmGm9Fc_MkMS4Tu30y4A2UPWolL90pgfL7sk7Q1GvKVR7MYl5ceAKNskEoXYvE)
    
-   It will match the first < a > element in the document and store it as link
    
-   We can now change its attribute like textContent and link
    

-   Document.querySelectorAll() - matches every element in the document that matches the selector and references to them to a NodeList, NodeList will be null if no matches
    
 	>  const matches = document.querySelectorAll("p");
    
-   Returns all the < p > elements in the document
    

### Older methods:

-   Document.getElementById() - selects an element with a given id attribute
    

	>  < p id="myId">My paragraph< /p >
    > const elementRef = document.getElementById('myId')
    

-   Document.getElementsByTagName() - returns an array-like object containing all the elements on the page of a given type like < p > or < a >
   
	> var allParas = document.getElementsByTagName('p');

# Creating and placing new nodes

-   We can create and append new nodes to existing ones
    
-   This selects element, “section”, and appends a created text node to it
-   This selects element “p”, and also appends a text node to it
    
```
 <body>
      <section>
        <img src="dinosaur.png" alt="A red Tyrannosaurus Rex: A two legged dinosaur standing upright like a human, with small arms, and a large head with lots of sharp teeth.">
        <p>Here we will add a link to the <a href="https://www.mozilla.org/">Mozilla homepage</a></p>
      </section>

	  <script>
		const link = document.querySelector('a');
		link.textContent = 'Mozilla Developer Network';
		link.href = 'https://developer.mozilla.org';
		
		const sect = document.querySelector('section');
		const para = document.createElement('p');
		para.textContent = 'We hope you enjoyed the ride.';
		sect.appendChild(para);
		
	   const text = document.createTextNode(' - some words');
	   const linkPara = document.querySelector('p');
	   linkPara.appendChild(text);
	   
	  </script>
  </body>
```
-   ![](https://lh4.googleusercontent.com/hPP3j1I9MI9vhlAh_rJ9fuXaTEDpz8NWkb1MIBGLtg8rDtmJbCblqMaenvu4q30EA5mZy1BYPriiXg0Q6FzU6Zi3gMo-smLYcX6SORqcADO-8uOOZ-nEXhxjnnXKFVUI1hw0fdxh)
    
-   ![](https://lh4.googleusercontent.com/ERYz6QfcxjkWoBNHJKBbMtLJSoX2Fxtma3wyZxl6O99_IvvRi7HTNIreP6tRsxJh363kQVkqEeqnERVRhNQKGb1ntDCpDTFxTt5oLU6GFY2GXZz35g_l1Dr5BHyyZmHgleTElQ06)
    

  

## Moving and removing elements

-   We can also move and delete elements from the DOM
    
-   To move a node, is Node.appendChild()
    
-   This appends element ‘p’ to ‘sections' , moving it to the bottom of the screen
	> sect.appendChild(linkPara);
    
```
<body>
      <section>
        <img src="dinosaur.png" alt="A red Tyrannosaurus Rex: A two legged dinosaur standing upright like a human, with small arms, and a large head with lots of sharp teeth.">
        <p>Here we will add a link to the <a href="https://www.mozilla.org/">Mozilla homepage</a></p>
      </section>

	  <script>
		const link = document.querySelector('a');
		link.textContent = 'Mozilla Developer Network';
		link.href = 'https://developer.mozilla.org';
		
		const sect = document.querySelector('section');
		const para = document.createElement('p');
		para.textContent = 'We hope you enjoyed the ride.';
		sect.appendChild(para);
		
	   const text = document.createTextNode(' - some words');
	   const linkPara = document.querySelector('p');
	   linkPara.appendChild(text);
	   sect.appendChild(linkPara);
	   
	  </script>
  </body>
```
-   ![](https://lh3.googleusercontent.com/NBNWlq0-75NyKdI5XbbhHlxByBG0YpcXUY8ffsLkYf6v2-nqAPVSkedv9sCIOVK0wSPYYWCC9XyWmXkiD4xxvWTap31Sp0Nr3kozWFJIe6Bqf7Od_DrWYAOlLKCbNzM1DXG3LXx4)
    

-   To remove a node from a Parent, use Node.removeChild()
    

> sect.removeChild(linkPara);

-   ![](https://lh6.googleusercontent.com/kBQe9HvB-5Zk3IIuFhh_6y1nDCCrVoFlcVK4tRewGK2FG1MDTxclKSyZfOorhvC7Es_kBLm0NU3_T0ivzsely_ryes3Zv46Pp6sR3zepmF6KnSbeJdaOB2qACuqoKjNIyL5oY3U8)
    

-   You can also remove a node with only a reference to itself
    

> linkPara.remove();

  
  
  
  

# Events

-   We can also use Events to dynamically manipulate the DOM
    

Three ways to add event handlers for a DOM element:

-   EventTarget.addEventListener
	 -   This is the way to use in modern web pages
  
```
 myButton.addEventListener(‘click’, greet, false)
   Function greet(event) {
   console.log(‘greet:’, arguments)
   alert(‘hello world’) }
```


-   HTML attribute
	-   The JS code in the attribute is passed the Event object via the event parameter
    

> <button onclick=”alert(‘Hello world!’)”>


    

-   DOM element properties
	-   The function takes an event parameter.
    
	-   Only one handler can be set per element and per event.
    
```
 myButton.onclick = function(event)
	{
		alert(‘Hello world’)
	}
```

    

-   In this example, we have unordered list, input, and button
    
-   ![](https://lh4.googleusercontent.com/kPky-_ue0VOl8yPEhvAGYmQ90cVB4O4DM_kautxKHGANWa23BOZ2tlkZCHBjHhwU4CA6KHKuveTHfY3uR4ZUReGyC68lvU9D_PDEsL3beoATU2WDGS3S5Z6evbnBc6pjf7BdL8eR)
    
-   Rendered in HTML gives us this
    
-   ![](https://lh3.googleusercontent.com/7h6jcPe_DruyVaflrHguaztBDyBmlgljFEo_YP9UGG5UPqGlDzAVzZsyNthgAPja_jlvF-swEsoZGhtp59S8pSBJe1vYfvSaSENjQhP4Wl-E4LZbAr1_ZnTlctXCb5sox0F2-rN4)
    
-   In our script, we select list, input, and button
    
-   On the event, button.onclick takes in the input.value to myItem and creates three new elements: a list item, a span, and a list button
    
-   It then appends the text and button to the list item. It also gives list button the ability to remove the list item
    
-   ![](https://lh6.googleusercontent.com/tWVhIM-PYVvsRPIYiz9yygTwaCmYe7EAevu7nSIfOjspbs9tiL4MmtEKVfjSf0Y_DbIAQ9YWb2ziMfhm2hh23H3mz7Ax6Zq1inyod3n66kA1EA-LBHIdCynkHj8kux-z7GoirZhj)
    
-   Thus, we can modify the DOM in real time by adding list items to our shopping list and deleting them by pressing the delete button.
    
-   ![](https://lh4.googleusercontent.com/OD9Q9AmAKyh46emVrZuHI_pGOUoau9GHqiFsQOSJBs5Iz-zYqU2Zn12hqcMtp49fPYNWEUr2ohW7tFT1SAY2mvAt4AXLZGFKdcee6N-MG0bcEoDehhDK77PZsHwuDh6s-iwKEBPA)
