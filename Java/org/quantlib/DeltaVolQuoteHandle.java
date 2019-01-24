/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package org.quantlib;

public class DeltaVolQuoteHandle {
  private transient long swigCPtr;
  protected transient boolean swigCMemOwn;

  protected DeltaVolQuoteHandle(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(DeltaVolQuoteHandle obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        QuantLibJNI.delete_DeltaVolQuoteHandle(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public DeltaVolQuoteHandle(DeltaVolQuote arg0) {
    this(QuantLibJNI.new_DeltaVolQuoteHandle__SWIG_0(DeltaVolQuote.getCPtr(arg0), arg0), true);
  }

  public DeltaVolQuoteHandle() {
    this(QuantLibJNI.new_DeltaVolQuoteHandle__SWIG_1(), true);
  }

  public DeltaVolQuote __deref__() {
    return new DeltaVolQuote(QuantLibJNI.DeltaVolQuoteHandle___deref__(swigCPtr, this), true);
  }

  public boolean empty() {
    return QuantLibJNI.DeltaVolQuoteHandle_empty(swigCPtr, this);
  }

  public Observable asObservable() {
    return new Observable(QuantLibJNI.DeltaVolQuoteHandle_asObservable(swigCPtr, this), true);
  }

  public double value() {
    return QuantLibJNI.DeltaVolQuoteHandle_value(swigCPtr, this);
  }

}
